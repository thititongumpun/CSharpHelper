import { Carousel } from "react-carousel-minimal";
import { data, captionStyle, slideNumberStyle } from "./data";

export const ImageCarousel = () => {
  return (
    <>
      <Carousel
        data={data}
        time={5000}
        width="940px"
        height="227px"
        captionStyle={captionStyle}
        radius="20px"
        slideNumber={false}
        slideNumberStyle={slideNumberStyle}
        captionPosition="bottom"
        automatic={true}
        dots={true}
        pauseIconColor="white"
        pauseIconSize="40px"
        slideBackgroundColor="darkgrey"
        slideImageFit="cover"
        thumbnails={true}
        thumbnailWidth="100px"
        style={{
          textAlign: "center",
          maxWidth: "850px",
          maxHeight: "500px",
          margin: "40px auto",
        }}
      />
    </>
  );
};
