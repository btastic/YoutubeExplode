using System;
using System.Collections.Generic;
using YoutubeExplode.Channels;
using YoutubeExplode.Common;
using YoutubeExplode.Videos.Chapters;

namespace YoutubeExplode.Videos
{
    /// <summary>
    /// YouTube video metadata.
    /// </summary>
    public class Video
    {
        /// <summary>
        /// Video ID.
        /// </summary>
        public VideoId Id { get; }

        /// <summary>
        /// Video URL.
        /// </summary>
        public string Url => $"https://www.youtube.com/watch?v={Id}";

        /// <summary>
        /// Video title.
        /// </summary>
        public string Title { get; }

        /// <summary>
        /// Video author.
        /// </summary>
        public string Author { get; }

        /// <summary>
        /// Video channel ID.
        /// </summary>
        public ChannelId ChannelId { get; }

        /// <summary>
        /// Video upload date.
        /// </summary>
        public DateTimeOffset UploadDate { get; }

        /// <summary>
        /// Video description.
        /// </summary>
        public string Description { get; }

        /// <summary>
        /// Duration of the video.
        /// </summary>
        public TimeSpan Duration { get; }

        /// <summary>
        /// Available thumbnails for this video.
        /// </summary>
        public ThumbnailSet Thumbnails { get; }

        /// <summary>
        /// Search keywords used for this video.
        /// </summary>
        public IReadOnlyList<string> Keywords { get; }

        /// <summary>
        /// Engagement statistics for this video.
        /// </summary>
        public Engagement Engagement { get; }

        /// <summary>
        /// Chapters for this video.
        /// Will be null for playlists and searches.
        /// </summary>
        public IReadOnlyList<Chapter>? Chapters { get; }

        /// <summary>
        /// Initializes an instance of <see cref="Video"/>.
        /// </summary>
        public Video(
            VideoId id,
            string title,
            string author,
            ChannelId channelId,
            DateTimeOffset uploadDate,
            string description,
            TimeSpan duration,
            ThumbnailSet thumbnails,
            IReadOnlyList<string> keywords,
            Engagement engagement,
            IReadOnlyList<Chapter>? chapters = null)
        {
            Id = id;
            Title = title;
            Author = author;
            ChannelId = channelId;
            UploadDate = uploadDate;
            Description = description;
            Duration = duration;
            Thumbnails = thumbnails;
            Keywords = keywords;
            Engagement = engagement;
            Chapters = chapters;
        }


        /// <inheritdoc />
        public override string ToString() => $"Video ({Title})";
    }
}