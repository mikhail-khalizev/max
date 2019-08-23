using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_9587-11ce7d84")]
        public void Method_1009_9587()
        {
            ii(0x1009_9587, 5); push(0x28);                             /* push 0x28 */
            ii(0x1009_958c, 5); call(Definitions.sys_check_available_stack_size, 0xc_c7c1); /* call 0x10165d52 */
            ii(0x1009_9591, 1); push(ebx);                              /* push ebx */
            ii(0x1009_9592, 1); push(ecx);                              /* push ecx */
            ii(0x1009_9593, 1); push(edx);                              /* push edx */
            ii(0x1009_9594, 1); push(esi);                              /* push esi */
            ii(0x1009_9595, 1); push(edi);                              /* push edi */
            ii(0x1009_9596, 1); push(ebp);                              /* push ebp */
            ii(0x1009_9597, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_9599, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1009_959f, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_95a2, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_95a4, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_95a7, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_95aa, 5); call(0x1013_ad71, 0xa_17c2);            /* call 0x1013ad71 */
            ii(0x1009_95af, 2); test(al, al);                           /* test al, al */
            ii(0x1009_95b1, 2); if(jz(0x1009_95d2, 0x1f)) goto l_0x1009_95d2; /* jz 0x100995d2 */
            ii(0x1009_95b3, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_95b6, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1009_95b9, 5); call(0x1008_af28, -0xe696);             /* call 0x1008af28 */
            ii(0x1009_95be, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1009_95c1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_95c4, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_95c7, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1009_95ca, 3); call_abs(memd[ds, edx + 0x14]);         /* call dword [edx+0x14] */
            ii(0x1009_95cd, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_95d0, 2); jmp(0x1009_95dc, 0xa); goto l_0x1009_95dc; /* jmp 0x100995dc */
        l_0x1009_95d2:
            ii(0x1009_95d2, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_95d5, 4); mov(ax, memw[ds, eax + 0xd]);           /* mov ax, [eax+0xd] */
            ii(0x1009_95d9, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1009_95dc:
            ii(0x1009_95dc, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_95df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_95e1, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_95e2, 1); pop(edi);                               /* pop edi */
            ii(0x1009_95e3, 1); pop(esi);                               /* pop esi */
            ii(0x1009_95e4, 1); pop(edx);                               /* pop edx */
            ii(0x1009_95e5, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_95e6, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_95e7, 1); ret();                                  /* ret */
        }
    }
}
