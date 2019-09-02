using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_b523-36935ff0")]
        public void Method_1010_b523()
        {
            ii(0x1010_b523, 5); push(0x28);                             /* push 0x28 */
            ii(0x1010_b528, 5); call(Definitions.sys_check_available_stack_size, 0x5_a825); /* call 0x10165d52 */
            ii(0x1010_b52d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_b52e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_b52f, 1); push(esi);                              /* push esi */
            ii(0x1010_b530, 1); push(edi);                              /* push edi */
            ii(0x1010_b531, 1); push(ebp);                              /* push ebp */
            ii(0x1010_b532, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_b534, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1010_b53a, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1010_b53d, 3); mov(memb[ss, ebp - 4], dl);             /* mov [ebp-0x4], dl */
            ii(0x1010_b540, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b543, 7); cmp(memd[ds, eax + 0x341], 0);          /* cmp dword [eax+0x341], 0x0 */
            ii(0x1010_b54a, 6); if(jz(0x1010_b5fb, 0xab)) goto l_0x1010_b5fb; /* jz 0x1010b5fb */
            ii(0x1010_b550, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x1010_b554, 2); if(jz(0x1010_b585, 0x2f)) goto l_0x1010_b585; /* jz 0x1010b585 */
            ii(0x1010_b556, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b559, 6); mov(edx, memd[ds, eax + 0x363]);        /* mov edx, [eax+0x363] */
            ii(0x1010_b55f, 3); sub(edx, 0x2e);                         /* sub edx, 0x2e */
            ii(0x1010_b562, 5); mov(eax, 0x4a);                         /* mov eax, 0x4a */
            ii(0x1010_b567, 5); call(0x100c_aafc, -0x4_0a70);           /* call 0x100caafc */
            ii(0x1010_b56c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b56f, 5); add(eax, 0x345);                        /* add eax, 0x345 */
            ii(0x1010_b574, 5); call(/* sys */ 0x1017_90ce, 0x6_db55);  /* call 0x101790ce */
            ii(0x1010_b579, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1010_b57b, 5); mov(eax, 0x4b);                         /* mov eax, 0x4b */
            ii(0x1010_b580, 5); call(0x100c_aafc, -0x4_0a89);           /* call 0x100caafc */
        l_0x1010_b585:
            ii(0x1010_b585, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b588, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b58e, 5); call(0x100e_b226, -0x2_036d);           /* call 0x100eb226 */
            ii(0x1010_b593, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b596, 7); cmp(memd[ds, eax + 0x341], 0);          /* cmp dword [eax+0x341], 0x0 */
            ii(0x1010_b59d, 2); if(jz(0x1010_b5d9, 0x3a)) goto l_0x1010_b5d9; /* jz 0x1010b5d9 */
            ii(0x1010_b59f, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b5a2, 6); mov(eax, memd[ds, eax + 0x341]);        /* mov eax, [eax+0x341] */
            ii(0x1010_b5a8, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1010_b5ab, 4); cmp(memd[ss, ebp - 0xc], 0);            /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1010_b5af, 2); if(jz(0x1010_b5c5, 0x14)) goto l_0x1010_b5c5; /* jz 0x1010b5c5 */
            ii(0x1010_b5b1, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_b5b3, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1010_b5b6, 5); call(Definitions.my_dtor_d6, -0x2_04e4); /* call 0x100eb0d7 */
            ii(0x1010_b5bb, 5); call(Definitions.sys_delete, 0x5_a9a4); /* call 0x10165f64 */
            ii(0x1010_b5c0, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1010_b5c3, 2); jmp(0x1010_b5cc, 7); goto l_0x1010_b5cc; /* jmp 0x1010b5cc */
        l_0x1010_b5c5:
            ii(0x1010_b5c5, 7); mov(memd[ss, ebp - 0x10], 0);           /* mov dword [ebp-0x10], 0x0 */
        l_0x1010_b5cc:
            ii(0x1010_b5cc, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b5cf, 10); mov(memd[ds, eax + 0x341], 0);         /* mov dword [eax+0x341], 0x0 */
        l_0x1010_b5d9:
            ii(0x1010_b5d9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b5dc, 10); mov(memd[ds, eax + 0x363], 0);         /* mov dword [eax+0x363], 0x0 */
            ii(0x1010_b5e6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b5e9, 5); call(0x1010_a69d, -0xf51);              /* call 0x1010a69d */
            ii(0x1010_b5ee, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1010_b5f1, 2); mov(eax, memd[ds, eax]);                /* mov eax, [eax] */
            ii(0x1010_b5f3, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1010_b5f6, 5); call(Definitions.sys_display_draw_0, 0x5_be89); /* call 0x10167484 */
        l_0x1010_b5fb:
            ii(0x1010_b5fb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_b5fd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_b5fe, 1); pop(edi);                               /* pop edi */
            ii(0x1010_b5ff, 1); pop(esi);                               /* pop esi */
            ii(0x1010_b600, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_b601, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_b602, 1); ret();                                  /* ret */
        }
    }
}
