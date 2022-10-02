import React from 'react'
import phimthu from '../img/hinhthu.jpg';
import bgleft from '../img/logogiff.gif';
import phim from '../img/hinhphim.png';
import "../css/style.css"
import "../css/gozha-nav.css"

export default function container() {
  return (
    <div>
        <div className="bgleft">
            <img alt='' src={bgleft}/>
        </div>
        
        <section     className="container">
        <div className="movie-best">
            <div className="col-sm-10 col-sm-offset-1 movie-best__rating">Today Best choice</div>
            <div className="col-sm-12 change--col">
                <div className="movie-beta__item ">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
                <div className="movie-beta__item second--item">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
                <div className="movie-beta__item third--item">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
                <div className="movie-beta__item hidden-xs">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
                <div className="movie-beta__item hidden-xs hidden-sm">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
                <div className="movie-beta__item hidden-xs hidden-sm">
                        <img alt='' src={phimthu}/>

                    <span className="best-rate">5.0</span>

                    <ul className="movie-beta__info">
                        <li><span className="best-voted">71 people voted today</span></li>
                        <li>
                            <p className="movie__time">169 min</p>
                            <p>Adventure | Drama | Fantasy </p>
                            <p>38 comments</p>
                        </li>
                        <li className="last-block">
                            <a href="movie-page-left.html" className="slide__link">more</a>
                        </li>
                    </ul>
                </div>
            </div>
            <div className="col-sm-10 col-sm-offset-1 movie-best__check">check all movies now playing</div>
        </div>
        <div className="clearfix"></div>

        <h2 id='target' className="page-heading heading--outcontainer">Now in the cinema</h2>

        <div className="col-sm-12">
            <div className="row">
            <div className="col-sm-8 col-md-9">
                <div className="movie movie--test movie--test--dark movie--test--left">
                                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
                <div className="movie movie--test movie--test--light movie--test--left">
                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
                <div className="movie movie--test movie--test--light movie--test--left">
                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
                <div className="movie movie--test movie--test--dark movie--test--left">
                                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
                <div className="movie movie--test movie--test--dark movie--test--left">
                                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
                <div className="movie movie--test movie--test--light movie--test--left">
                <div className="movie__images">
                                    <a href="movie-page-left.html" className="movie-beta__link">
                                        <img alt='' src={phim}/>
                                    </a>
                                </div>
                                <div className="movie__info">
                                    <a href='movie-page-left.html' className="movie__title">Gravity (2013)  </a>

                                    <p className="movie__time">91 min</p>

                                    <p className="movie__option"><a href="#">Sci-Fi</a> | <a href="#">Thriller</a> | <a href="#">Drama</a></p>
                                    
                                    <div className="movie__rate">
                                        <div className="score"></div>
                                        <span className="movie__rating">4.1</span>
                                    </div>               
                                </div>
                </div>
            </div>

                <aside className="col-sm-4 col-md-3">
                    <div className="sitebar first-banner--left">
                        {/* <div className="banner-wrap first-banner--left">
                            <img alt='banner' src={phim}/>
                        </div>

                        <div className="banner-wrap">
                            <img alt='banner' src={phim}/>
                        </div>

                        <div className="banner-wrap banner-wrap--last">
                            <img alt='banner' src={phim}/>
                        </div> */}

                        <div className="promo marginb-sm">
                        <div className="promo__head">Phim sắp chiếu</div>
                        <div className="promo__describe">for all smartphone and tablets</div>
                        <div className="promo__content">
                            <ul>
                                <li className="movie  store-variant">
                                        <a href="#">
                                            <div className="desc_movie">
                                                <img alt='banner' src={phim}/>
                                                <div className="movie_watch">
                                                    <span>Tên Phim</span>
                                                    <p>2022</p>
                                                    <span class="movie__rating_watch">4.1</span>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                <li className="movie store-variant">
                                        <a href="#">
                                            <div className="desc_movie">
                                                <img alt='banner' src={phim}/>
                                                <div className="movie_watch">
                                                    <span>Tên Phim</span>
                                                    <p>2022</p>
                                                    <span class="movie__rating_watch">4.1</span>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                                <li className="movie store-variant">
                                        <a href="#">
                                            <div className="desc_movie">
                                                <img alt='banner' src={phim}/>
                                                <div className="movie_watch">
                                                    <span>Tên Phim</span>
                                                    <p>2022</p>
                                                    <span class="movie__rating_watch">4.1</span>
                                                </div>
                                            </div>
                                        </a>
                                    </li>
                            </ul>
                        </div>
                    </div>

                    </div>
                </aside>
            </div>
        </div>
        <div className="col-sm-12">
            <h2 className="page-heading">Phim Yêu Thích</h2>

            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                        <img alt='banner' src={phim}/>
                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">"Thor: The Dark World" - World Premiere</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                    <img alt='banner' src={phim}/>

                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">30th Annual Night Of Stars Presented By The Fashion Group International</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                    <img alt='banner' src={phim}/>

                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">Hollywood Film Awards 2013</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
        </div>
    <div className="mg50px col-sm-12">
            <h2 className="page-heading">Latest news</h2>

            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                        <img alt='banner' src={phim}/>
                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">"Thor: The Dark World" - World Premiere</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                    <img alt='banner' src={phim}/>

                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">30th Annual Night Of Stars Presented By The Fashion Group International</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
            <div className="col-sm-4 similar-wrap col--remove">
                <div className="post post--preview post--preview--wide">
                    <div className="post__image">
                    <img alt='banner' src={phim}/>

                        <div className="social social--position social--hide">
                            <span className="social__name">Share:</span>
                            <a href='#' className="social__variant social--first fa fa-facebook"></a>
                            <a href='#' className="social__variant social--second fa fa-twitter"></a>
                            <a href='#' className="social__variant social--third fa fa-vk"></a>
                        </div>
                    </div>
                    <p className="post__date">22 October 2013 </p>
                    <a href="single-page-left.html" className="post__title">Hollywood Film Awards 2013</a>
                    <a href="single-page-left.html" className="btn read-more post--btn">read more</a>
                </div>
            </div>
        </div>
            
    </section> 
            
    </div>
  )
}
