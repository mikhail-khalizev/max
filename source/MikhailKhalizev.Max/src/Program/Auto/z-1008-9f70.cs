using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1008_9f70-94d37adc")]
        public void Method_1008_9f70()
        {
            ii(0x1008_9f70, 5); push(0x24);                             /* push 0x24 */
            ii(0x1008_9f75, 5); call(Definitions.sys_check_available_stack_size, 0xd_bdd8); /* call 0x10165d52 */
            ii(0x1008_9f7a, 1); push(ebx);                              /* push ebx */
            ii(0x1008_9f7b, 1); push(ecx);                              /* push ecx */
            ii(0x1008_9f7c, 1); push(edx);                              /* push edx */
            ii(0x1008_9f7d, 1); push(esi);                              /* push esi */
            ii(0x1008_9f7e, 1); push(edi);                              /* push edi */
            ii(0x1008_9f7f, 1); push(ebp);                              /* push ebp */
            ii(0x1008_9f80, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_9f82, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1008_9f88, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1008_9f8b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1008_9f8d, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9f90, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_9f93, 5); call(0x1013_ad11, 0xb_0d79);            /* call 0x1013ad11 */
            ii(0x1008_9f98, 2); test(al, al);                           /* test al, al */
            ii(0x1008_9f9a, 2); if(jz(0x1008_9fa5, 0x9)) goto l_0x1008_9fa5; /* jz 0x10089fa5 */
            ii(0x1008_9f9c, 7); mov(memd[ss, ebp - 0x8], 0);            /* mov dword [ebp-0x8], 0x0 */
            ii(0x1008_9fa3, 2); jmp(0x1008_9fb8, 0x13); goto l_0x1008_9fb8; /* jmp 0x10089fb8 */
        l_0x1008_9fa5:
            ii(0x1008_9fa5, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1008_9fa8, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x1008_9fab, 5); call(0x1008_a228, 0x278);               /* call 0x1008a228 */
            ii(0x1008_9fb0, 5); call(0x1008_a370, 0x3bb);               /* call 0x1008a370 */
            ii(0x1008_9fb5, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
        l_0x1008_9fb8:
            ii(0x1008_9fb8, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1008_9fbb, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_9fbd, 1); pop(ebp);                               /* pop ebp */
            ii(0x1008_9fbe, 1); pop(edi);                               /* pop edi */
            ii(0x1008_9fbf, 1); pop(esi);                               /* pop esi */
            ii(0x1008_9fc0, 1); pop(edx);                               /* pop edx */
            ii(0x1008_9fc1, 1); pop(ecx);                               /* pop ecx */
            ii(0x1008_9fc2, 1); pop(ebx);                               /* pop ebx */
            ii(0x1008_9fc3, 1); ret();                                  /* ret */
        }
    }
}
