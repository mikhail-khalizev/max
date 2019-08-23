using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1014_46da-fe5f0f6f")]
        public void Method_1014_46da()
        {
            ii(0x1014_46da, 5); push(0x24);                             /* push 0x24 */
            ii(0x1014_46df, 5); call(Definitions.sys_check_available_stack_size, 0x2_166e); /* call 0x10165d52 */
            ii(0x1014_46e4, 1); push(ebx);                              /* push ebx */
            ii(0x1014_46e5, 1); push(ecx);                              /* push ecx */
            ii(0x1014_46e6, 1); push(edx);                              /* push edx */
            ii(0x1014_46e7, 1); push(esi);                              /* push esi */
            ii(0x1014_46e8, 1); push(edi);                              /* push edi */
            ii(0x1014_46e9, 1); push(ebp);                              /* push ebp */
            ii(0x1014_46ea, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_46ec, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1014_46f2, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1014_46f5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_46f8, 6); mov(ebx, memd[ds, eax + 0x154]);        /* mov ebx, [eax+0x154] */
            ii(0x1014_46fe, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x1014_4701, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4704, 6); mov(edx, memd[ds, eax + 0x16c]);        /* mov edx, [eax+0x16c] */
            ii(0x1014_470a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1014_470d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4710, 3); mov(eax, memd[ds, eax + 0x12]);         /* mov eax, [eax+0x12] */
            ii(0x1014_4713, 5); call(0x1014_44e6, -0x232);              /* call 0x101444e6 */
            ii(0x1014_4718, 2); sub(eax, ebx);                          /* sub eax, ebx */
            ii(0x1014_471a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1014_471d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4720, 6); mov(eax, memd[ds, eax + 0x15a]);        /* mov eax, [eax+0x15a] */
            ii(0x1014_4726, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_4729, 3); cmp(eax, memd[ss, ebp - 0x8]);          /* cmp eax, [ebp-0x8] */
            ii(0x1014_472c, 2); if(jge(0x1014_473d, 0xf)) goto l_0x1014_473d; /* jge 0x1014473d */
            ii(0x1014_472e, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4731, 6); mov(eax, memd[ds, eax + 0x15a]);        /* mov eax, [eax+0x15a] */
            ii(0x1014_4737, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_473a, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1014_473d:
            ii(0x1014_473d, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_4741, 2); if(jz(0x1014_4797, 0x54)) goto l_0x1014_4797; /* jz 0x10144797 */
            ii(0x1014_4743, 4); cmp(memd[ss, ebp - 0x8], 0);            /* cmp dword [ebp-0x8], 0x0 */
            ii(0x1014_4747, 2); if(jle(0x1014_4772, 0x29)) goto l_0x1014_4772; /* jle 0x10144772 */
            ii(0x1014_4749, 5); mov(ecx, 0x20);                         /* mov ecx, 0x20 */
            ii(0x1014_474e, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4751, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_4756, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4759, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_475c, 5); call(0x1007_68e0, -0xc_de81);           /* call 0x100768e0 */
            ii(0x1014_4761, 5); call(0x1014_37d1, -0xf95);              /* call 0x101437d1 */
            ii(0x1014_4766, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_4768, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_476b, 5); call(0x1014_4674, -0xfc);               /* call 0x10144674 */
            ii(0x1014_4770, 2); jmp(0x1014_4797, 0x25); goto l_0x1014_4797; /* jmp 0x10144797 */
        l_0x1014_4772:
            ii(0x1014_4772, 3); mov(ebx, memd[ss, ebp - 0x8]);          /* mov ebx, [ebp-0x8] */
            ii(0x1014_4775, 2); neg(ebx);                               /* neg ebx */
            ii(0x1014_4777, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x1014_477c, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_477f, 3); add(eax, 0x4e);                         /* add eax, 0x4e */
            ii(0x1014_4782, 5); call(0x1007_68e0, -0xc_dea7);           /* call 0x100768e0 */
            ii(0x1014_4787, 5); call(0x1014_3b69, -0xc23);              /* call 0x10143b69 */
            ii(0x1014_478c, 3); mov(edx, memd[ss, ebp - 0x8]);          /* mov edx, [ebp-0x8] */
            ii(0x1014_478f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1014_4792, 5); call(0x1014_4674, -0x123);              /* call 0x10144674 */
        l_0x1014_4797:
            ii(0x1014_4797, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_4799, 1); pop(ebp);                               /* pop ebp */
            ii(0x1014_479a, 1); pop(edi);                               /* pop edi */
            ii(0x1014_479b, 1); pop(esi);                               /* pop esi */
            ii(0x1014_479c, 1); pop(edx);                               /* pop edx */
            ii(0x1014_479d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1014_479e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1014_479f, 1); ret();                                  /* ret */
        }
    }
}
