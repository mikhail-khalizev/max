using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_73a8-573fc328")]
        public void Method_1008_73a8()
        {
            ii(0x1008_73a8, 5); push(0x28);                             /* push 0x28 */
            ii(0x1008_73ad, 5); call(Definitions.sys_check_available_stack_size, 0xd_e9a0); /* call 0x10165d52 */
            ii(0x1008_73b2, 1); push(ebx);                              /* push ebx */
            ii(0x1008_73b3, 1); push(ecx);                              /* push ecx */
            ii(0x1008_73b4, 1); push(esi);                              /* push esi */
            ii(0x1008_73b5, 1); push(edi);                              /* push edi */
            ii(0x1008_73b6, 1); push(ebp);                              /* push ebp */
            ii(0x1008_73b7, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_73b9, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1008_73bf, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1008_73c2, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1008_73c5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_73c7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_73ca, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_73cd, 5); call(0x1013_ad11, 0xb_393f);            /* call 0x1013ad11 */
            ii(0x1008_73d2, 2); test(al, al);                           /* test al, al */
            ii(0x1008_73d4, 2); if(jz(0x1008_73e6, 0x10)) goto l_0x1008_73e6; /* jz 0x100873e6 */
            ii(0x1008_73d6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_73d9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_73dc, 5); call(0x100a_2ce8, 0x1_b907);            /* call 0x100a2ce8 */
            ii(0x1008_73e1, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1008_73e4, 2); jmp(0x1008_7406, 0x20); goto l_0x1008_7406; /* jmp 0x10087406 */
        l_0x1008_73e6:
            ii(0x1008_73e6, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_73e9, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1008_73ec, 5); call(0x1008_af28, 0x3b37);              /* call 0x1008af28 */
            ii(0x1008_73f1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1008_73f4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_73f7, 3); mov(ebx, memd[ds, eax + 0x2]);          /* mov ebx, [eax+0x2] */
            ii(0x1008_73fa, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1008_73fd, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1008_7400, 3); call_abs(memd[ds, ebx + 0x1c]);         /* call dword [ebx+0x1c] */
            ii(0x1008_7403, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
        l_0x1008_7406:
            ii(0x1008_7406, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1008_7409, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_740b, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_740c, 1); pop(edi);                               /* pop edi */
            ii(0x1008_740d, 1); pop(esi);                               /* pop esi */
            ii(0x1008_740e, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_740f, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_7410, 1); ret();                                  /* ret */
        }
    }
}
