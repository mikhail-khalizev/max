using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_ecb8-3be117ba")]
        public void Method_1009_ecb8()
        {
            ii(0x1009_ecb8, 5); push(0x34);                             /* push 0x34 */
            ii(0x1009_ecbd, 5); call(Definitions.sys_check_available_stack_size, 0xc_7090); /* call 0x10165d52 */
            ii(0x1009_ecc2, 1); push(ebx);                              /* push ebx */
            ii(0x1009_ecc3, 1); push(ecx);                              /* push ecx */
            ii(0x1009_ecc4, 1); push(edx);                              /* push edx */
            ii(0x1009_ecc5, 1); push(esi);                              /* push esi */
            ii(0x1009_ecc6, 1); push(edi);                              /* push edi */
            ii(0x1009_ecc7, 1); push(ebp);                              /* push ebp */
            ii(0x1009_ecc8, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_ecca, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1009_ecd0, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1009_ecd3, 5); mov(eax, 0x1d);                         /* mov eax, 0x1d */
            ii(0x1009_ecd8, 5); call(Definitions.sys_new, 0xc_7123);    /* call 0x10165e00 */
            ii(0x1009_ecdd, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x1009_ece0, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ece3, 3); mov(memd[ss, ebp - 16], eax);           /* mov [ebp-0x10], eax */
            ii(0x1009_ece6, 4); cmp(memd[ss, ebp - 16], 0);             /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1009_ecea, 2); if(jz(0x1009_ed08, 0x1c)) goto l_0x1009_ed08; /* jz 0x1009ed08 */
            ii(0x1009_ecec, 3); mov(ebx, memd[ss, ebp - 4]);            /* mov ebx, [ebp-0x4] */
            ii(0x1009_ecef, 3); add(ebx, 0x13);                         /* add ebx, 0x13 */
            ii(0x1009_ecf2, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1009_ecf5, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x1009_ecf8, 5); call(Definitions.my_ctor_c12, 0x736f);  /* call 0x100a606c */
            ii(0x1009_ecfd, 3); mov(memd[ss, ebp - 20], eax);           /* mov [ebp-0x14], eax */
            ii(0x1009_ed00, 3); mov(eax, memd[ss, ebp - 20]);           /* mov eax, [ebp-0x14] */
            ii(0x1009_ed03, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1009_ed06, 2); jmp(0x1009_ed0e, 6); goto l_0x1009_ed0e; /* jmp 0x1009ed0e */
        l_0x1009_ed08:
            ii(0x1009_ed08, 3); mov(eax, memd[ss, ebp - 16]);           /* mov eax, [ebp-0x10] */
            ii(0x1009_ed0b, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
        l_0x1009_ed0e:
            ii(0x1009_ed0e, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x1009_ed11, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed14, 5); call(0x1008_a914, -0x1_4405);           /* call 0x1008a914 */
            ii(0x1009_ed19, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ed1c, 4); cmp(memb[ds, eax + 85], 0);             /* cmp byte [eax+0x55], 0x0 */
            ii(0x1009_ed20, 2); if(jz(0x1009_ed34, 0x12)) goto l_0x1009_ed34; /* jz 0x1009ed34 */
            ii(0x1009_ed22, 5); mov(edx, 0x32);                         /* mov edx, 0x32 */
            ii(0x1009_ed27, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed2a, 5); call(0x1008_a7dc, -0x1_4553);           /* call 0x1008a7dc */
            ii(0x1009_ed2f, 5); call(0x100a_63bc, 0x7688);              /* call 0x100a63bc */
        l_0x1009_ed34:
            ii(0x1009_ed34, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ed37, 4); cmp(memb[ds, eax + 114], 0);            /* cmp byte [eax+0x72], 0x0 */
            ii(0x1009_ed3b, 2); if(jz(0x1009_ed4f, 0x12)) goto l_0x1009_ed4f; /* jz 0x1009ed4f */
            ii(0x1009_ed3d, 5); mov(edx, 0x4f);                         /* mov edx, 0x4f */
            ii(0x1009_ed42, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed45, 5); call(0x1008_a7dc, -0x1_456e);           /* call 0x1008a7dc */
            ii(0x1009_ed4a, 5); call(0x100a_63bc, 0x766d);              /* call 0x100a63bc */
        l_0x1009_ed4f:
            ii(0x1009_ed4f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ed52, 4); cmp(memb[ds, eax + 103], 0);            /* cmp byte [eax+0x67], 0x0 */
            ii(0x1009_ed56, 2); if(jz(0x1009_ed6a, 0x12)) goto l_0x1009_ed6a; /* jz 0x1009ed6a */
            ii(0x1009_ed58, 5); mov(edx, 0x44);                         /* mov edx, 0x44 */
            ii(0x1009_ed5d, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed60, 5); call(0x1008_a7dc, -0x1_4589);           /* call 0x1008a7dc */
            ii(0x1009_ed65, 5); call(0x100a_63bc, 0x7652);              /* call 0x100a63bc */
        l_0x1009_ed6a:
            ii(0x1009_ed6a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ed6d, 4); cmp(memb[ds, eax + 106], 0);            /* cmp byte [eax+0x6a], 0x0 */
            ii(0x1009_ed71, 2); if(jz(0x1009_ed85, 0x12)) goto l_0x1009_ed85; /* jz 0x1009ed85 */
            ii(0x1009_ed73, 5); mov(edx, 0x47);                         /* mov edx, 0x47 */
            ii(0x1009_ed78, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed7b, 5); call(0x1008_a7dc, -0x1_45a4);           /* call 0x1008a7dc */
            ii(0x1009_ed80, 5); call(0x100a_63bc, 0x7637);              /* call 0x100a63bc */
        l_0x1009_ed85:
            ii(0x1009_ed85, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1009_ed88, 4); cmp(memb[ds, eax + 101], 0);            /* cmp byte [eax+0x65], 0x0 */
            ii(0x1009_ed8c, 2); if(jz(0x1009_eda0, 0x12)) goto l_0x1009_eda0; /* jz 0x1009eda0 */
            ii(0x1009_ed8e, 5); mov(edx, 0x42);                         /* mov edx, 0x42 */
            ii(0x1009_ed93, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_ed96, 5); call(0x1008_a7dc, -0x1_45bf);           /* call 0x1008a7dc */
            ii(0x1009_ed9b, 5); call(0x100a_63bc, 0x761c);              /* call 0x100a63bc */
        l_0x1009_eda0:
            ii(0x1009_eda0, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_eda3, 5); call(0x1008_a838, -0x1_4570);           /* call 0x1008a838 */
            ii(0x1009_eda8, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1009_edaa, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x1009_edaf, 5); call(0x100a_4d50, 0x5f9c);              /* call 0x100a4d50 */
            ii(0x1009_edb4, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_edb6, 3); lea(eax, memd[ss, ebp - 24]);           /* lea eax, [ebp-0x18] */
            ii(0x1009_edb9, 5); call(0x1008_8cbc, -0x1_6102);           /* call 0x10088cbc */
            ii(0x1009_edbe, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_edc0, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_edc1, 1); pop(edi);                               /* pop edi */
            ii(0x1009_edc2, 1); pop(esi);                               /* pop esi */
            ii(0x1009_edc3, 1); pop(edx);                               /* pop edx */
            ii(0x1009_edc4, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_edc5, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_edc6, 1); ret();                                  /* ret */
        }
    }
}
