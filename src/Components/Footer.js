import React from 'react'
import "../css/style.css"
import "../css/gozha-nav.css"
export default function Footer() {
  return (
    <footer className="footer-wrapper">
            <section className="container">
                <div className="col-xs-4 col-md-2 footer-nav">
                    <ul className="nav-link">
                        <li><a href="#" className="nav-link__item">Hệ thống rạp</a></li>
                        <li><a href="movie-list-left.html" className="nav-link__item">Phim</a></li>
                        <li><a href="trailer.html" className="nav-link__item">Trailers</a></li>
                        <li><a href="rates-left.html" className="nav-link__item">Đánh giá</a></li>
                    </ul>
                </div>
                <div className="col-xs-4 col-md-2 footer-nav">
                    <ul className="nav-link">
                        <li><a href="coming-soon.html" className="nav-link__item">Sắp diễn ra</a></li>
                        <li><a href="cinema-list.html" className="nav-link__item">Phim</a></li>
                        <li><a href="offers.html" className="nav-link__item">Ưu đãi</a></li>
                        <li><a href="news-left.html" className="nav-link__item">Sư kiện</a></li>
                    </ul>
                </div>
                <div className="col-xs-4 col-md-2 footer-nav">
                    <ul className="nav-link">
                        <li><a href="#" className="nav-link__item">Điều khoản sử dụng</a></li>
                        <li><a href="gallery-four.html" className="nav-link__item">Văn phòng</a></li>
                        <li><a href="contact.html" className="nav-link__item">Liên hệ</a></li>
                        
                    </ul>
                </div>
                <div className="col-xs-12 col-md-6">
                    <div className="footer-info">
                        <p className="heading-special--small">Rạp Phim Thầy Quy <span className="title-edition">in the social media </span></p>

                        <div className="social">
                            <a href='#' className="social__variant fa fa-facebook"></a>
                            <a href='#' className="social__variant fa fa-twitter"></a>
                            {/* <a href='#' className="social__variant fa fa-vk"></a> */}
                            <a href='#' className="social__variant fa fa-instagram"></a>
                            <a href='#' className="social__variant fa fa-tumblr"></a>
                            <a href='#' className="social__variant fa fa-pinterest"></a>
                        </div>
                        
                        <div className="clearfix"></div>
                        <p className="copy">&copy;Rạp Phim Thầy Quy, 2022. All rights reserved. Done by Olia Gozha</p>
                    </div>
                </div>
            </section>
        </footer>
  )
}
