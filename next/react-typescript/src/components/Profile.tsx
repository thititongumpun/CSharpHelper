interface IProps {
  name: string;
  imageId: string;
}

export const Profile = ({name, imageId}: IProps) => {
  const imageUrl = (
    `https://i.imgur.com/${imageId}s.jpg`
  );
  return (
    <img 
      src={imageUrl}
      alt={name}
      className="avatar" 
    />
  )
}