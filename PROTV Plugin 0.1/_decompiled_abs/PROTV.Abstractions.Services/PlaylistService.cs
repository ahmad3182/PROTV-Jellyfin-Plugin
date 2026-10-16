using System;
using System.Threading.Tasks;
using PROTV.Abstractions.Apis;
using PROTV.Abstractions.Common;
using PROTV.Abstractions.DataTransferObjects;
using PROTV.Abstractions.Search;

namespace PROTV.Abstractions.Services;

public class PlaylistService : IPlaylistService
{
	private readonly IAuthService PjcBlxWbG;

	private readonly IStoreContext ujxUDFs7w;

	private readonly IPTVApis dPx1WJM7c;

	public PlaylistService(IPTVApis iPTVApis, IAuthService authService, IStoreContext storeContext)
	{
		uiiVNagWnDNnTWnFgq.IB3tMMvyI(uiiVNagWnDNnTWnFgq.JyKLgPcm8);
		base._002Ector();
		PjcBlxWbG = authService;
		dPx1WJM7c = iPTVApis;
		ujxUDFs7w = storeContext;
	}

	public async Task<ResponseList<PlaylistResponseDto<T>>> GetPlaylistsAsync<T>(ApiQuery<PlaylistSearch, GeneralSort> query)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				return (!TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW)) ? (await i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap).GetPlaylistsAsync<T>(query)) : (await i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ).GetPlaylistsAsync<T>(query));
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<Response<PlaylistResponseDto<T>>> CreatePlaylisAsyncAsync<T>(string name)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<PlaylistResponseDto<T>> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IPlaylistApi playlistApi = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ);
					NewPlaylistRequest newPlaylistRequest = new NewPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newPlaylistRequest, PlaylistType.Song, IjogDZnP2No3tnYHLL2.S4unBB5Swi);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(newPlaylistRequest, name, QV5Py2LOX8yx6ajM6nW.yTUn1ZNZyX);
					result = await playlistApi.CreatePlaylistAsync<T>(newPlaylistRequest);
				}
				else
				{
					IPlaylistApi playlistApi2 = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap);
					NewPlaylistRequest newPlaylistRequest2 = new NewPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newPlaylistRequest2, PlaylistType.Song, IjogDZnP2No3tnYHLL2.S4unBB5Swi);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(newPlaylistRequest2, name, QV5Py2LOX8yx6ajM6nW.yTUn1ZNZyX);
					result = await playlistApi2.CreatePlaylistAsync<T>(newPlaylistRequest2);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<Response<string>> AddMediaToPlayListAsync(int MediaId, int PlaylistId)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<string> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IPlaylistApi playlistApi = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ);
					NewMediaToPlaylistRequest newMediaToPlaylistRequest = new NewMediaToPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newMediaToPlaylistRequest, PlaylistType.Song, IjogDZnP2No3tnYHLL2.lftnykYjcN);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest, MediaId, GTWJ1Nn6Vm4L7wbejIm.DSfnohkHxA);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest, PlaylistId, GTWJ1Nn6Vm4L7wbejIm.UDVn8fXNBk);
					result = await CHN8H3nNKN2VLbkRb7G.IB3tMMvyI(playlistApi, newMediaToPlaylistRequest, CHN8H3nNKN2VLbkRb7G.jmsnGYQgR4);
				}
				else
				{
					IPlaylistApi playlistApi2 = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap);
					NewMediaToPlaylistRequest newMediaToPlaylistRequest2 = new NewMediaToPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newMediaToPlaylistRequest2, PlaylistType.Song, IjogDZnP2No3tnYHLL2.lftnykYjcN);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest2, MediaId, GTWJ1Nn6Vm4L7wbejIm.DSfnohkHxA);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest2, PlaylistId, GTWJ1Nn6Vm4L7wbejIm.UDVn8fXNBk);
					result = await CHN8H3nNKN2VLbkRb7G.IB3tMMvyI(playlistApi2, newMediaToPlaylistRequest2, CHN8H3nNKN2VLbkRb7G.jmsnGYQgR4);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<Response<string>> RemovPlaylistAsync(int Id)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<string> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IPlaylistApi playlistApi = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ);
					UpdatePlaylistRequest updatePlaylistRequest = new UpdatePlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(updatePlaylistRequest, PlaylistType.Song, IjogDZnP2No3tnYHLL2.uaTnhmu2QD);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(updatePlaylistRequest, Id, GTWJ1Nn6Vm4L7wbejIm.cdgnAdTgJ6);
					result = await NNJjYnnsyxgVxNgKhYH.IB3tMMvyI(playlistApi, updatePlaylistRequest, NNJjYnnsyxgVxNgKhYH.ExgnxPfq4i);
				}
				else
				{
					IPlaylistApi playlistApi2 = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap);
					UpdatePlaylistRequest updatePlaylistRequest2 = new UpdatePlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(updatePlaylistRequest2, PlaylistType.Song, IjogDZnP2No3tnYHLL2.uaTnhmu2QD);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(updatePlaylistRequest2, Id, GTWJ1Nn6Vm4L7wbejIm.cdgnAdTgJ6);
					result = await NNJjYnnsyxgVxNgKhYH.IB3tMMvyI(playlistApi2, updatePlaylistRequest2, NNJjYnnsyxgVxNgKhYH.ExgnxPfq4i);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<Response<string>> RemoveMediaFromPlaylist(int MediaId, int PlaylistId)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<string> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IPlaylistApi playlistApi = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ);
					NewMediaToPlaylistRequest newMediaToPlaylistRequest = new NewMediaToPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newMediaToPlaylistRequest, PlaylistType.Song, IjogDZnP2No3tnYHLL2.lftnykYjcN);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest, MediaId, GTWJ1Nn6Vm4L7wbejIm.DSfnohkHxA);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest, PlaylistId, GTWJ1Nn6Vm4L7wbejIm.UDVn8fXNBk);
					result = await CHN8H3nNKN2VLbkRb7G.IB3tMMvyI(playlistApi, newMediaToPlaylistRequest, CHN8H3nNKN2VLbkRb7G.zEYnzCV85f);
				}
				else
				{
					IPlaylistApi playlistApi2 = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap);
					NewMediaToPlaylistRequest newMediaToPlaylistRequest2 = new NewMediaToPlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(newMediaToPlaylistRequest2, PlaylistType.Song, IjogDZnP2No3tnYHLL2.lftnykYjcN);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest2, MediaId, GTWJ1Nn6Vm4L7wbejIm.DSfnohkHxA);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(newMediaToPlaylistRequest2, PlaylistId, GTWJ1Nn6Vm4L7wbejIm.UDVn8fXNBk);
					result = await CHN8H3nNKN2VLbkRb7G.IB3tMMvyI(playlistApi2, newMediaToPlaylistRequest2, CHN8H3nNKN2VLbkRb7G.zEYnzCV85f);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}

	public async Task<Response<PlaylistResponseDto<T>>> UpdatePlaylisAsyncAsync<T>(int MediaId, string title)
	{
		bool tryAgain = true;
		while (tryAgain)
		{
			try
			{
				Response<PlaylistResponseDto<T>> result;
				if (TLD0W5K9yiTCdcMEKT.IB3tMMvyI(ujxUDFs7w, TLD0W5K9yiTCdcMEKT.nOQLzI2sZW))
				{
					IPlaylistApi playlistApi = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.On3nDBLeiZ);
					UpdatePlaylistRequest updatePlaylistRequest = new UpdatePlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(updatePlaylistRequest, PlaylistType.Song, IjogDZnP2No3tnYHLL2.uaTnhmu2QD);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(updatePlaylistRequest, MediaId, GTWJ1Nn6Vm4L7wbejIm.cdgnAdTgJ6);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(updatePlaylistRequest, title, QV5Py2LOX8yx6ajM6nW.kipvw8b7wA);
					result = await playlistApi.RenamePlaylistAsync<T>(updatePlaylistRequest);
				}
				else
				{
					IPlaylistApi playlistApi2 = i2gPsKnYgdA6qZXnUbs.IB3tMMvyI(dPx1WJM7c, i2gPsKnYgdA6qZXnUbs.BipnaYOjap);
					UpdatePlaylistRequest updatePlaylistRequest2 = new UpdatePlaylistRequest();
					IjogDZnP2No3tnYHLL2.IB3tMMvyI(updatePlaylistRequest2, PlaylistType.Song, IjogDZnP2No3tnYHLL2.uaTnhmu2QD);
					GTWJ1Nn6Vm4L7wbejIm.IB3tMMvyI(updatePlaylistRequest2, MediaId, GTWJ1Nn6Vm4L7wbejIm.cdgnAdTgJ6);
					QV5Py2LOX8yx6ajM6nW.IB3tMMvyI(updatePlaylistRequest2, title, QV5Py2LOX8yx6ajM6nW.kipvw8b7wA);
					result = await playlistApi2.RenamePlaylistAsync<T>(updatePlaylistRequest2);
				}
				return result;
			}
			catch (Exception e)
			{
				PROTVException ex = new PROTVException(e);
				if (CDq5XOVSkTWxZo0hfQU.IB3tMMvyI(ex, CDq5XOVSkTWxZo0hfQU.wJ8Vnql80E) == ExceptionType.AuthorizationTokenInvalid)
				{
					try
					{
						await d81QmNVvT2C1ISNMQLb.IB3tMMvyI(PjcBlxWbG, d81QmNVvT2C1ISNMQLb.eQmVM4BpWn);
						tryAgain = true;
					}
					catch (Exception e2)
					{
						ex = new PROTVException(e2);
						throw ex;
					}
					continue;
				}
				throw ex;
			}
		}
		return null;
	}
}
