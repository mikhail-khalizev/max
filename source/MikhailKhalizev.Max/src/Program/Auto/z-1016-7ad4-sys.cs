using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_7ad4-d78e1653")]
        public void /* sys */ Method_1016_7ad4()
        {
            ii(0x1016_7ad4, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_7ad5, 1); pushd(esi);                             /* push esi */
            ii(0x1016_7ad6, 1); pushd(edi);                             /* push edi */
            ii(0x1016_7ad7, 1); pushd(ebp);                             /* push ebp */
            ii(0x1016_7ad8, 3); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1016_7adb, 2); mov(esi, edx);                          /* mov esi, edx */
            ii(0x1016_7add, 2); mov(ebp, ebx);                          /* mov ebp, ebx */
            ii(0x1016_7adf, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1016_7ae1, 7); mov(edi, memd_a32[ds, eax * 4 + 0x101c_b134]); /* mov edi, [eax*4+0x101cb134] */
            ii(0x1016_7ae8, 6); mov(edx, memd_a32[ds, 0x101c_b2d8]);    /* mov edx, [0x101cb2d8] */
            ii(0x1016_7aee, 1); inc(edi);                               /* inc edi */
            ii(0x1016_7aef, 2); cmp(edi, edx);                          /* cmp edi, edx */
            ii(0x1016_7af1, 2); if(jld(0x1016_7b44, 0x51)) goto l_0x1016_7b44; /* jl 0x10167b44 */
            ii(0x1016_7af3, 2); jmpd(0x1016_7b50, 0x5b); goto l_0x1016_7b50; /* jmp 0x10167b50 */
        l_0x1016_7af5:
            ii(0x1016_7af5, 6); mov(eax, memd_a32[ds, ecx + 0x101c_b1fc]); /* mov eax, [ecx+0x101cb1fc] */
            ii(0x1016_7afb, 3); mov(dl, memb_a32[ds, eax + 0x4]);       /* mov dl, [eax+0x4] */
            ii(0x1016_7afe, 3); test(dl, 0x8);                          /* test dl, 0x8 */
            ii(0x1016_7b01, 2); if(jnzd(0x1016_7b34, 0x31)) goto l_0x1016_7b34; /* jnz 0x10167b34 */
            ii(0x1016_7b03, 7); cmp(memd_a32[ds, 0x101c_b2c4], 0);      /* cmp dword [0x101cb2c4], 0x0 */
            ii(0x1016_7b0a, 2); if(jzd(0x1016_7b24, 0x18)) goto l_0x1016_7b24; /* jz 0x10167b24 */
            ii(0x1016_7b0c, 3); test(dl, 0x20);                         /* test dl, 0x20 */
            ii(0x1016_7b0f, 2); if(jzd(0x1016_7b24, 0x13)) goto l_0x1016_7b24; /* jz 0x10167b24 */
            ii(0x1016_7b11, 7); cmp(memd_a32[ds, 0x101c_b2d0], 0);      /* cmp dword [0x101cb2d0], 0x0 */
            ii(0x1016_7b18, 2); if(jnzd(0x1016_7b34, 0x1a)) goto l_0x1016_7b34; /* jnz 0x10167b34 */
            ii(0x1016_7b1a, 3); lea(edx, eax + 0x8);                    /* lea edx, [eax+0x8] */
            ii(0x1016_7b1d, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1016_7b1f, 5); calld(/* sys */ 0x1016_7500, -0x624);   /* call 0x10167500 */
        l_0x1016_7b24:
            ii(0x1016_7b24, 6); mov(edx, memd_a32[ds, ecx + 0x101c_b1fc]); /* mov edx, [ecx+0x101cb1fc] */
            ii(0x1016_7b2a, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7b2c, 3); add(edx, 0x8);                          /* add edx, 0x8 */
            ii(0x1016_7b2f, 5); calld(/* sys */ 0x1018_5d74, 0x1_e240); /* call 0x10185d74 */
        l_0x1016_7b34:
            ii(0x1016_7b34, 6); mov(ebx, memd_a32[ds, 0x101c_b2d8]);    /* mov ebx, [0x101cb2d8] */
            ii(0x1016_7b3a, 1); inc(edi);                               /* inc edi */
            ii(0x1016_7b3b, 3); add(ecx, 0x4);                          /* add ecx, 0x4 */
            ii(0x1016_7b3e, 2); cmp(edi, ebx);                          /* cmp edi, ebx */
            ii(0x1016_7b40, 2); if(jld(0x1016_7b4b, 0x9)) goto l_0x1016_7b4b; /* jl 0x10167b4b */
            ii(0x1016_7b42, 2); jmpd(0x1016_7b50, 0xc); goto l_0x1016_7b50; /* jmp 0x10167b50 */
        l_0x1016_7b44:
            ii(0x1016_7b44, 7); lea(ecx, edi * 4 + 0);                  /* lea ecx, [edi*4] */
        l_0x1016_7b4b:
            ii(0x1016_7b4b, 3); cmp(memd_a32[ds, esi], 0);              /* cmp dword [esi], 0x0 */
            ii(0x1016_7b4e, 2); if(jnzd(0x1016_7af5, -0x5b)) goto l_0x1016_7af5; /* jnz 0x10167af5 */
        l_0x1016_7b50:
            ii(0x1016_7b50, 6); cmp(ebp, memd_a32[ds, 0x101b_ddd8]);    /* cmp ebp, [0x101bddd8] */
            ii(0x1016_7b56, 2); if(jzd(0x1016_7b5c, 0x4)) goto l_0x1016_7b5c; /* jz 0x10167b5c */
            ii(0x1016_7b58, 2); test(ebp, ebp);                         /* test ebp, ebp */
            ii(0x1016_7b5a, 2); if(jnzd(0x1016_7b75, 0x19)) goto l_0x1016_7b75; /* jnz 0x10167b75 */
        l_0x1016_7b5c:
            ii(0x1016_7b5c, 5); calld(/* sys */ 0x1016_c350, 0x47ef);   /* call 0x1016c350 */
            ii(0x1016_7b61, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_7b63, 2); if(jnzd(0x1016_7b75, 0x10)) goto l_0x1016_7b75; /* jnz 0x10167b75 */
            ii(0x1016_7b65, 2); mov(eax, esp);                          /* mov eax, esp */
            ii(0x1016_7b67, 2); mov(edx, esp);                          /* mov edx, esp */
            ii(0x1016_7b69, 5); calld(/* sys */ 0x1016_c25c, 0x46ee);   /* call 0x1016c25c */
            ii(0x1016_7b6e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x1016_7b70, 5); calld(/* sys */ 0x1018_5d74, 0x1_e1ff); /* call 0x10185d74 */
        l_0x1016_7b75:
            ii(0x1016_7b75, 3); add(esp, 0x10);                         /* add esp, 0x10 */
            ii(0x1016_7b78, 1); popd(ebp);                              /* pop ebp */
            ii(0x1016_7b79, 1); popd(edi);                              /* pop edi */
            ii(0x1016_7b7a, 1); popd(esi);                              /* pop esi */
            ii(0x1016_7b7b, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_7b7c, 1); retd();                                 /* ret */
        }
    }
}
