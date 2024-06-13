﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace ChatGPT.Net.DTO.ChatGPTUnofficial
{
    public class ChatGptUnofficialMessageRequest
    {
        [JsonProperty("action")]
        public string Action { get; set; } = "next";

        [JsonProperty("messages")]
        public List<MessageElement> Messages { get; set; } = new List<MessageElement>();

        [JsonProperty("parent_message_id")]
        public string ParentMessageId { get; set; } = Guid.NewGuid().ToString();
        [JsonProperty("conversation_id")]
        public string ConversationId { get; set; }

        [JsonProperty("model")]
        public string Model { get; set; } = "text-davinci-002-render-sha";

        [JsonProperty("timezone_offset_min")]
        public long TimezoneOffsetMin { get; set; } = -180;
    }

    public class MessageElement
    {
        [JsonProperty("id")]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        [JsonProperty("author")]
        public Author Author { get; set; } = new Author();

        [JsonProperty("content")]
        public Content Content { get; set; } = new Content();
    }

    public class Author
    {
        [JsonProperty("role")]
        public string Role { get; set; } = "user";
    }

    public class Content
    {
        [JsonProperty("content_type")]
        public string ContentType { get; set; } = "text";

        [JsonProperty("parts")]
        public List<string> Parts { get; set; } = new List<string>();
    }
}

