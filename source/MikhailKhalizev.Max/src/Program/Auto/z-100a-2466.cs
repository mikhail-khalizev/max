using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_2466-5ff67ce1")]
        public void Method_100a_2466()
        {
            ii(0x100a_2466, 5); push(0x2c);                             /* push 0x2c */
            ii(0x100a_246b, 5); call(Definitions.sys_check_available_stack_size, 0xc_38e2); /* call 0x10165d52 */
            ii(0x100a_2470, 1); push(esi);                              /* push esi */
            ii(0x100a_2471, 1); push(edi);                              /* push edi */
            ii(0x100a_2472, 1); push(ebp);                              /* push ebp */
            ii(0x100a_2473, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_2475, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100a_247b, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x100a_247e, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x100a_2481, 3); mov(memd[ss, ebp - 0x8], ebx);          /* mov [ebp-0x8], ebx */
            ii(0x100a_2484, 3); mov(memd[ss, ebp - 0x4], ecx);          /* mov [ebp-0x4], ecx */
            ii(0x100a_2487, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x100a_248a, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x100a_248d, 2); jmp(0x100a_2495, 0x6); goto l_0x100a_2495; /* jmp 0x100a2495 */
        l_0x100a_248f:
            ii(0x100a_248f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_2492, 3); inc(memd[ss, ebp - 0x18]);              /* inc dword [ebp-0x18] */
        l_0x100a_2495:
            ii(0x100a_2495, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x100a_2498, 4); cmp(ax, memw[ss, ebp - 0x8]);           /* cmp ax, [ebp-0x8] */
            ii(0x100a_249c, 2); if(jg(0x100a_24d6, 0x38)) goto l_0x100a_24d6; /* jg 0x100a24d6 */
            ii(0x100a_249e, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100a_24a1, 3); mov(memd[ss, ebp - 0x1c], eax);         /* mov [ebp-0x1c], eax */
            ii(0x100a_24a4, 2); jmp(0x100a_24ac, 0x6); goto l_0x100a_24ac; /* jmp 0x100a24ac */
        l_0x100a_24a6:
            ii(0x100a_24a6, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_24a9, 3); inc(memd[ss, ebp - 0x1c]);              /* inc dword [ebp-0x1c] */
        l_0x100a_24ac:
            ii(0x100a_24ac, 3); mov(eax, memd[ss, ebp - 0x1c]);         /* mov eax, [ebp-0x1c] */
            ii(0x100a_24af, 4); cmp(ax, memw[ss, ebp - 0x4]);           /* cmp ax, [ebp-0x4] */
            ii(0x100a_24b3, 2); if(jg(0x100a_24d4, 0x1f)) goto l_0x100a_24d4; /* jg 0x100a24d4 */
            ii(0x100a_24b5, 4); movsx(edx, memw[ss, ebp - 0x1c]);       /* movsx edx, word [ebp-0x1c] */
            ii(0x100a_24b9, 4); movsx(eax, memw[ss, ebp - 0x18]);       /* movsx eax, word [ebp-0x18] */
            ii(0x100a_24bd, 5); call(0x1007_3d48, -0x2_e77a);           /* call 0x10073d48 */
            ii(0x100a_24c2, 5); and(eax, 0xffff);                       /* and eax, 0xffff */
            ii(0x100a_24c7, 3); cmp(eax, 0x1);                          /* cmp eax, 0x1 */
            ii(0x100a_24ca, 2); if(jz(0x100a_24d2, 0x6)) goto l_0x100a_24d2; /* jz 0x100a24d2 */
            ii(0x100a_24cc, 4); mov(memb[ss, ebp - 0x14], 0);           /* mov byte [ebp-0x14], 0x0 */
            ii(0x100a_24d0, 2); jmp(0x100a_24da, 0x8); goto l_0x100a_24da; /* jmp 0x100a24da */
        l_0x100a_24d2:
            ii(0x100a_24d2, 2); jmp(0x100a_24a6, -0x2e); goto l_0x100a_24a6; /* jmp 0x100a24a6 */
        l_0x100a_24d4:
            ii(0x100a_24d4, 2); jmp(0x100a_248f, -0x47); goto l_0x100a_248f; /* jmp 0x100a248f */
        l_0x100a_24d6:
            ii(0x100a_24d6, 4); mov(memb[ss, ebp - 0x14], 0x1);         /* mov byte [ebp-0x14], 0x1 */
        l_0x100a_24da:
            ii(0x100a_24da, 3); mov(al, memb[ss, ebp - 0x14]);          /* mov al, [ebp-0x14] */
            ii(0x100a_24dd, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100a_24df, 1); pop(ebp);                               /* pop ebp */
            ii(0x100a_24e0, 1); pop(edi);                               /* pop edi */
            ii(0x100a_24e1, 1); pop(esi);                               /* pop esi */
            ii(0x100a_24e2, 1); ret();                                  /* ret */
        }
    }
}
