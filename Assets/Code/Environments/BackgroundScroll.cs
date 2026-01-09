using System;
using TMPro;
using UnityEngine;

namespace Code.Environments
{
    public class BackgroundScroll : MonoBehaviour
    {
        [SerializeField] private float parallaxOffset;
        
        private SpriteRenderer _spriteRenderer;
        private Material _backgroundMat;

        private float _currentScroll;
        private float _ratio;
        private Transform _mainCamTrm;
        private float _beforePos;
        
        private readonly int _offsetHash = Shader.PropertyToID("_Offset");

        private void Awake()
        {
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _backgroundMat = _spriteRenderer.material;
            _currentScroll = 0;
            _ratio = 1f / _spriteRenderer.bounds.size.x;

            _mainCamTrm = Camera.main?.transform;
        }

        private void Start()
        {
            _beforePos = _mainCamTrm.position.x;
        }

        private void Update()
        {
            float delta = _mainCamTrm.position.x - _beforePos;
            
            _beforePos = _mainCamTrm.position.x;
            _currentScroll += delta * parallaxOffset * _ratio;
            
            _backgroundMat.SetVector(_offsetHash, new Vector2(_currentScroll, 0));
        }
    }
}
