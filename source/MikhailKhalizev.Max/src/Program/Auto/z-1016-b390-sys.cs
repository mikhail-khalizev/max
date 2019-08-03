using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("c158b686-8519-466c-b446-6ba7fa0c8ec3")]
        public void /* sys */ Method_1016_b390()
        {
            ii(0x1016_b390, 1); pushd(ebx);                             /* push ebx */
            ii(0x1016_b391, 1); pushd(ecx);                             /* push ecx */
            ii(0x1016_b392, 1); pushd(edx);                             /* push edx */
            ii(0x1016_b393, 6); mov(ebx, memd_a32[ds, 0x101c_fb58]);    /* mov ebx, [0x101cfb58] */
            ii(0x1016_b399, 6); mov(edx, memd_a32[ds, 0x101c_fb54]);    /* mov edx, [0x101cfb54] */
            ii(0x1016_b39f, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_b3a1, 2); if(jnzd(0x1016_b3d6, 0x33)) goto l_0x1016_b3d6; /* jnz 0x1016b3d6 */
            ii(0x1016_b3a3, 7); cmp(memd_a32[ds, 0x101c_fb7c], 0);      /* cmp dword [0x101cfb7c], 0x0 */
            ii(0x1016_b3aa, 2); if(jnzd(0x1016_b3d6, 0x2a)) goto l_0x1016_b3d6; /* jnz 0x1016b3d6 */
            ii(0x1016_b3ac, 5); mov(ecx, 0x101c_fb54);                  /* mov ecx, 0x101cfb54 */
            ii(0x1016_b3b1, 2); test(edx, edx);                         /* test edx, edx */
            ii(0x1016_b3b3, 2); if(jzd(0x1016_b3d6, 0x21)) goto l_0x1016_b3d6; /* jz 0x1016b3d6 */
        l_0x1016_b3b5:
            ii(0x1016_b3b5, 2); mov(ah, memb_a32[ds, edx]);             /* mov ah, [edx] */
            ii(0x1016_b3b7, 3); mov(ebx, memd_a32[ds, edx + 0x8]);      /* mov ebx, [edx+0x8] */
            ii(0x1016_b3ba, 3); test(ah, 0x1);                          /* test ah, 0x1 */
            ii(0x1016_b3bd, 2); if(jzd(0x1016_b3ca, 0xb)) goto l_0x1016_b3ca; /* jz 0x1016b3ca */
            ii(0x1016_b3bf, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1016_b3c1, 2); mov(memd_a32[ds, ecx], ebx);            /* mov [ecx], ebx */
            ii(0x1016_b3c3, 5); calld(Definitions.sys_free_internal, 0x1708c); /* call 0x10182454 */
            ii(0x1016_b3c8, 2); jmpd(0x1016_b3d0, 0x6); goto l_0x1016_b3d0; /* jmp 0x1016b3d0 */
        l_0x1016_b3ca:
            ii(0x1016_b3ca, 3); calld_abs(memd_a32[ds, edx + 0x4]);     /* call dword [edx+0x4] */
            ii(0x1016_b3cd, 3); lea(ecx, edx + 0x8);                    /* lea ecx, [edx+0x8] */
        l_0x1016_b3d0:
            ii(0x1016_b3d0, 2); mov(edx, ebx);                          /* mov edx, ebx */
            ii(0x1016_b3d2, 2); test(ebx, ebx);                         /* test ebx, ebx */
            ii(0x1016_b3d4, 2); if(jnzd(0x1016_b3b5, -0x21)) goto l_0x1016_b3b5; /* jnz 0x1016b3b5 */
        l_0x1016_b3d6:
            ii(0x1016_b3d6, 1); popd(edx);                              /* pop edx */
            ii(0x1016_b3d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1016_b3d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1016_b3d9, 1); retd(); return;                         /* ret */
        }
    }
}