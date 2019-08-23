using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1009_a329-85a4ff18")]
        public void Method_1009_a329()
        {
            ii(0x1009_a329, 5); push(0x24);                             /* push 0x24 */
            ii(0x1009_a32e, 5); call(Definitions.sys_check_available_stack_size, 0xc_ba1f); /* call 0x10165d52 */
            ii(0x1009_a333, 1); push(ebx);                              /* push ebx */
            ii(0x1009_a334, 1); push(ecx);                              /* push ecx */
            ii(0x1009_a335, 1); push(edx);                              /* push edx */
            ii(0x1009_a336, 1); push(esi);                              /* push esi */
            ii(0x1009_a337, 1); push(edi);                              /* push edi */
            ii(0x1009_a338, 1); push(ebp);                              /* push ebp */
            ii(0x1009_a339, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_a33b, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1009_a341, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1009_a344, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1009_a346, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a349, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_a34c, 5); call(0x1013_ad11, 0xa_09c0);            /* call 0x1013ad11 */
            ii(0x1009_a351, 2); test(al, al);                           /* test al, al */
            ii(0x1009_a353, 2); if(jz(0x1009_a367, 0x12)) goto l_0x1009_a367; /* jz 0x1009a367 */
            ii(0x1009_a355, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1009_a358, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1009_a35b, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a35e, 3); mov(edx, memd[ds, eax + 0x2]);          /* mov edx, [eax+0x2] */
            ii(0x1009_a361, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1009_a364, 3); call_abs(memd[ds, edx + 0x70]);         /* call dword [edx+0x70] */
        l_0x1009_a367:
            ii(0x1009_a367, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_a369, 1); pop(ebp);                               /* pop ebp */
            ii(0x1009_a36a, 1); pop(edi);                               /* pop edi */
            ii(0x1009_a36b, 1); pop(esi);                               /* pop esi */
            ii(0x1009_a36c, 1); pop(edx);                               /* pop edx */
            ii(0x1009_a36d, 1); pop(ecx);                               /* pop ecx */
            ii(0x1009_a36e, 1); pop(ebx);                               /* pop ebx */
            ii(0x1009_a36f, 1); ret();                                  /* ret */
        }
    }
}
