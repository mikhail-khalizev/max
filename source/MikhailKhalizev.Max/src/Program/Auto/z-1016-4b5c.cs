using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1016_4b5c-812ff63e")]
        public void Method_1016_4b5c()
        {
            ii(0x1016_4b5c, 5); push(0x40);                             /* push 0x40 */
            ii(0x1016_4b61, 5); call(Definitions.sys_check_available_stack_size, 0x11ec); /* call 0x10165d52 */
            ii(0x1016_4b66, 1); push(esi);                              /* push esi */
            ii(0x1016_4b67, 1); push(edi);                              /* push edi */
            ii(0x1016_4b68, 1); push(ebp);                              /* push ebp */
            ii(0x1016_4b69, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1016_4b6b, 6); sub(esp, 0x30);                         /* sub esp, 0x30 */
            ii(0x1016_4b71, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1016_4b74, 3); mov(memd[ss, ebp - 12], edx);           /* mov [ebp-0xc], edx */
            ii(0x1016_4b77, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1016_4b7a, 3); mov(memd[ss, ebp - 4], ecx);            /* mov [ebp-0x4], ecx */
            ii(0x1016_4b7d, 3); lea(eax, memd[ss, ebp - 28]);           /* lea eax, [ebp-0x1c] */
            ii(0x1016_4b80, 5); call(0x1007_20b1, -0xf_2ad4);           /* call 0x100720b1 */
            ii(0x1016_4b85, 3); lea(eax, memd[ss, ebp - 40]);           /* lea eax, [ebp-0x28] */
            ii(0x1016_4b88, 5); call(0x1007_20b1, -0xf_2adc);           /* call 0x100720b1 */
            ii(0x1016_4b8d, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4b90, 5); call(0x1007_6204, -0xe_e991);           /* call 0x10076204 */
            ii(0x1016_4b95, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1016_4b97, 2); if(jz(0x1016_4baf, 0x16)) goto l_0x1016_4baf; /* jz 0x10164baf */
            ii(0x1016_4b99, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4b9c, 5); call(0x1007_6204, -0xe_e99d);           /* call 0x10076204 */
            ii(0x1016_4ba1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1016_4ba3, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1016_4ba6, 5); call(0x1007_6204, -0xe_e9a7);           /* call 0x10076204 */
            ii(0x1016_4bab, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x1016_4bad, 2); if(jnz(0x1016_4bd3, 0x24)) goto l_0x1016_4bd3; /* jnz 0x10164bd3 */
        l_0x1016_4baf:
            ii(0x1016_4baf, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4bb2, 4); mov(dx, memw[ds, eax + 82]);            /* mov dx, [eax+0x52] */
            ii(0x1016_4bb6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1016_4bb9, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1016_4bbc, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4bbf, 5); call(0x1007_623c, -0xe_e988);           /* call 0x1007623c */
            ii(0x1016_4bc4, 4); mov(dx, memw[ds, eax + 25]);            /* mov dx, [eax+0x19] */
            ii(0x1016_4bc8, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1016_4bcb, 3); mov(memw[ds, eax], dx);                 /* mov [eax], dx */
            ii(0x1016_4bce, 5); jmp(0x1016_4c5d, 0x8a); goto l_0x1016_4c5d; /* jmp 0x10164c5d */
        l_0x1016_4bd3:
            ii(0x1016_4bd3, 3); lea(ebx, memd[ss, ebp - 40]);           /* lea ebx, [ebp-0x28] */
            ii(0x1016_4bd6, 3); lea(edx, memd[ss, ebp - 28]);           /* lea edx, [ebp-0x1c] */
            ii(0x1016_4bd9, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4bdc, 5); call(0x1007_6204, -0xe_e9dd);           /* call 0x10076204 */
            ii(0x1016_4be1, 5); call(0x1014_3616, -0x2_15d0);           /* call 0x10143616 */
            ii(0x1016_4be6, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1016_4be9, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1016_4bec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1016_4bef, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1016_4bf2, 6); mov(al, memb[ds, eax + 0x101c_81d5]);   /* mov al, [eax+0x101c81d5] */
            ii(0x1016_4bf8, 3); mov(memb[ss, ebp - 44], al);            /* mov [ebp-0x2c], al */
            ii(0x1016_4bfb, 2); jmp(0x1016_4c3b, 0x3e); goto l_0x1016_4c3b; /* jmp 0x10164c3b */
        l_0x1016_4bfd:
            ii(0x1016_4bfd, 3); mov(eax, memd[ss, ebp - 26]);           /* mov eax, [ebp-0x1a] */
            ii(0x1016_4c00, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_4c03, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c06, 3); mov(eax, memd[ss, ebp - 38]);           /* mov eax, [ebp-0x26] */
            ii(0x1016_4c09, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_4c0c, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c0f, 2); jmp(0x1016_4c5d, 0x4c); goto l_0x1016_4c5d; /* jmp 0x10164c5d */
        l_0x1016_4c11:
            ii(0x1016_4c11, 3); mov(eax, memd[ss, ebp - 24]);           /* mov eax, [ebp-0x18] */
            ii(0x1016_4c14, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_4c17, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c1a, 3); mov(eax, memd[ss, ebp - 36]);           /* mov eax, [ebp-0x24] */
            ii(0x1016_4c1d, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_4c20, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c23, 2); jmp(0x1016_4c5d, 0x38); goto l_0x1016_4c5d; /* jmp 0x10164c5d */
        l_0x1016_4c25:
            ii(0x1016_4c25, 3); mov(eax, memd[ss, ebp - 28]);           /* mov eax, [ebp-0x1c] */
            ii(0x1016_4c28, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1016_4c2b, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c2e, 3); mov(eax, memd[ss, ebp - 40]);           /* mov eax, [ebp-0x28] */
            ii(0x1016_4c31, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1016_4c34, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1016_4c37, 2); jmp(0x1016_4c5d, 0x24); goto l_0x1016_4c5d; /* jmp 0x10164c5d */
        l_0x1016_4c39:
            ii(0x1016_4c39, 2); jmp(0x1016_4c5d, 0x22); goto l_0x1016_4c5d; /* jmp 0x10164c5d */
        l_0x1016_4c3b:
            ii(0x1016_4c3b, 3); mov(al, memb[ss, ebp - 44]);            /* mov al, [ebp-0x2c] */
            ii(0x1016_4c3e, 3); mov(memb[ss, ebp - 48], al);            /* mov [ebp-0x30], al */
            ii(0x1016_4c41, 4); cmp(memb[ss, ebp - 48], 2);             /* cmp byte [ebp-0x30], 0x2 */
            ii(0x1016_4c45, 2); if(jb(0x1016_4c55, 0xe)) goto l_0x1016_4c55; /* jb 0x10164c55 */
            ii(0x1016_4c47, 4); cmp(memb[ss, ebp - 48], 2);             /* cmp byte [ebp-0x30], 0x2 */
            ii(0x1016_4c4b, 2); if(jbe(0x1016_4c11, -0x3c)) goto l_0x1016_4c11; /* jbe 0x10164c11 */
            ii(0x1016_4c4d, 4); cmp(memb[ss, ebp - 48], 3);             /* cmp byte [ebp-0x30], 0x3 */
            ii(0x1016_4c51, 2); if(jz(0x1016_4c25, -0x2e)) goto l_0x1016_4c25; /* jz 0x10164c25 */
            ii(0x1016_4c53, 2); jmp(0x1016_4c39, -0x1c); goto l_0x1016_4c39; /* jmp 0x10164c39 */
        l_0x1016_4c55:
            ii(0x1016_4c55, 4); cmp(memb[ss, ebp - 48], 1);             /* cmp byte [ebp-0x30], 0x1 */
            ii(0x1016_4c59, 2); if(jz(0x1016_4bfd, -0x5e)) goto l_0x1016_4bfd; /* jz 0x10164bfd */
            ii(0x1016_4c5b, 2); jmp(0x1016_4c39, -0x24); goto l_0x1016_4c39; /* jmp 0x10164c39 */
        l_0x1016_4c5d:
            ii(0x1016_4c5d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1016_4c5f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1016_4c60, 1); pop(edi);                               /* pop edi */
            ii(0x1016_4c61, 1); pop(esi);                               /* pop esi */
            ii(0x1016_4c62, 1); ret();                                  /* ret */
        }
    }
}
