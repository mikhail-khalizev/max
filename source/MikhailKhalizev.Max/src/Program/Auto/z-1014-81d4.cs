using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_81d4-51c2a2ac")]
        public void Method_1014_81d4()
        {
            ii(0x1014_81d4, 1); pushad();                               /* pushad */
            ii(0x1014_81d5, 1); pushd(ds);                              /* push ds */
            ii(0x1014_81d6, 1); pushd(es);                              /* push es */
            ii(0x1014_81d7, 2); pushd(fs);                              /* push fs */
            ii(0x1014_81d9, 2); pushd(gs);                              /* push gs */
            ii(0x1014_81db, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_81dd, 6); sub(esp, 0x4);                          /* sub esp, 0x4 */
            ii(0x1014_81e3, 1); cld();                                  /* cld */
            ii(0x1014_81e4, 5); calld(/* sys */ 0x1016_c9d0, 0x2_47e7); /* call 0x1016c9d0 */
            ii(0x1014_81e9, 7); cmp(memd_a32[ds, 0x101c_8138], 0);      /* cmp dword [0x101c8138], 0x0 */
            ii(0x1014_81f0, 6); if(jzd(0x1014_828a, 0x94)) goto l_0x1014_828a; /* jz 0x1014828a */
            ii(0x1014_81f6, 5); mov(edx, 0x80);                         /* mov edx, 0x80 */
            ii(0x1014_81fb, 5); mov(eax, 0x43);                         /* mov eax, 0x43 */
            ii(0x1014_8200, 5); calld(/* sys */ 0x1018_0fc8, 0x3_8dc3); /* call 0x10180fc8 */
            ii(0x1014_8205, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_820a, 5); calld(/* sys */ 0x1018_0fd2, 0x3_8dc3); /* call 0x10180fd2 */
            ii(0x1014_820f, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_8212, 5); mov(eax, 0x42);                         /* mov eax, 0x42 */
            ii(0x1014_8217, 5); calld(/* sys */ 0x1018_0fd2, 0x3_8db6); /* call 0x10180fd2 */
            ii(0x1014_821c, 3); shl(eax, 0x8);                          /* shl eax, 0x8 */
            ii(0x1014_821f, 3); add(memd_a32[ss, ebp - 0x4], eax);      /* add [ebp-0x4], eax */
            ii(0x1014_8222, 5); mov(eax, memd_a32[ds, 0x101c_8130]);    /* mov eax, [0x101c8130] */
            ii(0x1014_8227, 3); sub(eax, memd_a32[ss, ebp - 0x4]);      /* sub eax, [ebp-0x4] */
            ii(0x1014_822a, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1014_822f, 6); add(memd_a32[ds, 0x101c_8134], eax);    /* add [0x101c8134], eax */
            ii(0x1014_8235, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_8238, 5); mov(memd_a32[ds, 0x101c_8130], eax);    /* mov [0x101c8130], eax */
            ii(0x1014_823d, 5); mov(eax, memd_a32[ds, 0x101c_812c]);    /* mov eax, [0x101c812c] */
            ii(0x1014_8242, 6); inc(memd_a32[ds, 0x101c_812c]);         /* inc dword [0x101c812c] */
            ii(0x1014_8248, 5); mov(eax, memd_a32[ds, 0x101c_8120]);    /* mov eax, [0x101c8120] */
            ii(0x1014_824d, 6); inc(memd_a32[ds, 0x101c_8120]);         /* inc dword [0x101c8120] */
            ii(0x1014_8253, 7); cmp(memd_a32[ds, 0x101c_8120], 0x4);    /* cmp dword [0x101c8120], 0x4 */
            ii(0x1014_825a, 2); if(jld(0x1014_827b, 0x1f)) goto l_0x1014_827b; /* jl 0x1014827b */
            ii(0x1014_825c, 10); mov(memd_a32[ds, 0x101c_8120], 0);     /* mov dword [0x101c8120], 0x0 */
            ii(0x1014_8266, 6); mov(ax, memw_a32[ds, 0x101c_8128]);     /* mov ax, [0x101c8128] */
            ii(0x1014_826c, 6); mov(ebx, memd_a32[ds, 0x101c_8124]);    /* mov ebx, [0x101c8124] */
            ii(0x1014_8272, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_8274, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1014_8276, 5); calld(/* sys */ 0x1016_c9dc, 0x2_4761); /* call 0x1016c9dc */
        l_0x1014_827b:
            ii(0x1014_827b, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_8280, 5); mov(eax, 0x20);                         /* mov eax, 0x20 */
            ii(0x1014_8285, 5); calld(/* sys */ 0x1018_0fc8, 0x3_8d3e); /* call 0x10180fc8 */
        l_0x1014_828a:
            ii(0x1014_828a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_828c, 2); popd(gs);                               /* pop gs */
            ii(0x1014_828e, 2); popd(fs);                               /* pop fs */
            ii(0x1014_8290, 1); popd(es);                               /* pop es */
            ii(0x1014_8291, 1); popd(ds);                               /* pop ds */
            ii(0x1014_8292, 1); popad();                                /* popad */
            ii(0x1014_8293, 1); iretd(); return;                        /* iretd */
        }
    }
}
