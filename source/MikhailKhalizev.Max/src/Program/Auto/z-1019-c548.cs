using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3b346b09-5c90-4a76-8fda-db06b9d5f9cb")]
        public void Method_1019_c548()
        {
            ii(0x1019_c548, 1); pushd(ebx);                             /* push ebx */
            ii(0x1019_c549, 1); pushd(edx);                             /* push edx */
            ii(0x1019_c54a, 3); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1019_c54d, 4); mov(ebx, memd_a32[ss, esp + 0x1c]);     /* mov ebx, [esp+0x1c] */
            ii(0x1019_c551, 4); mov(eax, memd_a32[ss, esp + 0x14]);     /* mov eax, [esp+0x14] */
            ii(0x1019_c555, 3); mov(memd_a32[ss, esp], eax);            /* mov [esp], eax */
            ii(0x1019_c558, 4); mov(eax, memd_a32[ss, esp + 0x18]);     /* mov eax, [esp+0x18] */
            ii(0x1019_c55c, 4); mov(memd_a32[ss, esp + 0x4], eax);      /* mov [esp+0x4], eax */
            ii(0x1019_c560, 4); mov(eax, memd_a32[ss, esp + 0x6]);      /* mov eax, [esp+0x6] */
            ii(0x1019_c564, 5); and(eax, 0x7ff0);                       /* and eax, 0x7ff0 */
            ii(0x1019_c569, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x1019_c56e, 5); cmp(eax, 0x7ff0);                       /* cmp eax, 0x7ff0 */
            ii(0x1019_c573, 2); if(jnzd(0x1019_c5d0, 0x5b)) goto l_0x1019_c5d0; /* jnz 0x1019c5d0 */
            ii(0x1019_c575, 4); mov(edx, memd_a32[ss, esp + 0x6]);      /* mov edx, [esp+0x6] */
            ii(0x1019_c579, 2); xor(dl, dl);                            /* xor dl, dl */
            ii(0x1019_c57b, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x1019_c57d, 3); and(dh, 0x80);                          /* and dh, 0x80 */
            ii(0x1019_c580, 6); and(edx, 0xffff);                       /* and edx, 0xffff */
            ii(0x1019_c586, 2); if(jzd(0x1019_c58e, 0x6)) goto l_0x1019_c58e; /* jz 0x1019c58e */
            ii(0x1019_c588, 3); lea(eax, ebx + 0x1);                    /* lea eax, [ebx+0x1] */
            ii(0x1019_c58b, 3); mov(memb_a32[ds, ebx], 0x2d);           /* mov byte [ebx], 0x2d */
        l_0x1019_c58e:
            ii(0x1019_c58e, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1019_c590, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_c592, 5); mov(bx, memw_a32[ss, esp + 0x2]);       /* mov bx, [esp+0x2] */
            ii(0x1019_c597, 4); mov(dx, memw_a32[ss, esp]);             /* mov dx, [esp] */
            ii(0x1019_c59b, 2); or(ebx, edx);                           /* or ebx, edx */
            ii(0x1019_c59d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1019_c59f, 5); mov(dx, memw_a32[ss, esp + 0x4]);       /* mov dx, [esp+0x4] */
            ii(0x1019_c5a4, 2); or(edx, ebx);                           /* or edx, ebx */
            ii(0x1019_c5a6, 4); mov(ebx, memd_a32[ss, esp + 0x6]);      /* mov ebx, [esp+0x6] */
            ii(0x1019_c5aa, 2); xor(bh, bh);                            /* xor bh, bh */
            ii(0x1019_c5ac, 3); and(bl, 0xf);                           /* and bl, 0xf */
            ii(0x1019_c5af, 6); and(ebx, 0xffff);                       /* and ebx, 0xffff */
            ii(0x1019_c5b5, 2); or(edx, ebx);                           /* or edx, ebx */
            ii(0x1019_c5b7, 2); if(jnzd(0x1019_c5c1, 0x8)) goto l_0x1019_c5c1; /* jnz 0x1019c5c1 */
            ii(0x1019_c5b9, 6); mov(edx, memd_a32[ds, 0x101b_3848]);    /* mov edx, [0x101b3848] */
            ii(0x1019_c5bf, 2); jmpd(0x1019_c5c7, 0x6); goto l_0x1019_c5c7; /* jmp 0x1019c5c7 */
        l_0x1019_c5c1:
            ii(0x1019_c5c1, 6); mov(edx, memd_a32[ds, 0x101b_384c]);    /* mov edx, [0x101b384c] */
        l_0x1019_c5c7:
            ii(0x1019_c5c7, 2); mov(memd_a32[ds, eax], edx);            /* mov [eax], edx */
            ii(0x1019_c5c9, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1019_c5ce, 2); jmpd(0x1019_c5d2, 0x2); goto l_0x1019_c5d2; /* jmp 0x1019c5d2 */
        l_0x1019_c5d0:
            ii(0x1019_c5d0, 2); xor(eax, eax);                          /* xor eax, eax */
        l_0x1019_c5d2:
            ii(0x1019_c5d2, 3); add(esp, 0x8);                          /* add esp, 0x8 */
            ii(0x1019_c5d5, 1); popd(edx);                              /* pop edx */
            ii(0x1019_c5d6, 1); popd(ebx);                              /* pop ebx */
            ii(0x1019_c5d7, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
