using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_9e2a-74f329fe")]
        public void Method_1015_9e2a()
        {
            ii(0x1015_9e2a, 5); push(0x24);                             /* push 0x24 */
            ii(0x1015_9e2f, 5); call(Definitions.sys_check_available_stack_size, 0xbf1e); /* call 0x10165d52 */
            ii(0x1015_9e34, 1); push(ebx);                              /* push ebx */
            ii(0x1015_9e35, 1); push(ecx);                              /* push ecx */
            ii(0x1015_9e36, 1); push(esi);                              /* push esi */
            ii(0x1015_9e37, 1); push(edi);                              /* push edi */
            ii(0x1015_9e38, 1); push(ebp);                              /* push ebp */
            ii(0x1015_9e39, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_9e3b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x1015_9e41, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1015_9e44, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1015_9e47, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9e4a, 4); cmp(memb[ds, eax + 0x3d], 7);           /* cmp byte [eax+0x3d], 0x7 */
            ii(0x1015_9e4e, 2); if(jnz(0x1015_9e6c, 0x1c)) goto l_0x1015_9e6c; /* jnz 0x10159e6c */
            ii(0x1015_9e50, 5); mov(eax, 0x1015_9712);                  /* mov eax, 0x10159712 */
            ii(0x1015_9e55, 1); push(eax);                              /* push eax */
            ii(0x1015_9e56, 5); mov(ecx, 0x37);                         /* mov ecx, 0x37 */
            ii(0x1015_9e5b, 5); mov(ebx, StringDefinitions.Stop7);      /* mov ebx, 0x101b2698 */
            ii(0x1015_9e60, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9e62, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9e65, 5); call(0x1015_7ccf, -0x219b);             /* call 0x10157ccf */
            ii(0x1015_9e6a, 2); jmp(0x1015_9e86, 0x1a); goto l_0x1015_9e86; /* jmp 0x10159e86 */
        l_0x1015_9e6c:
            ii(0x1015_9e6c, 5); mov(eax, 0x1015_9680);                  /* mov eax, 0x10159680 */
            ii(0x1015_9e71, 1); push(eax);                              /* push eax */
            ii(0x1015_9e72, 5); mov(ecx, 0x32);                         /* mov ecx, 0x32 */
            ii(0x1015_9e77, 5); mov(ebx, StringDefinitions.Start7);     /* mov ebx, 0x101b269d */
            ii(0x1015_9e7c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1015_9e7e, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_9e81, 5); call(0x1015_7ccf, -0x21b7);             /* call 0x10157ccf */
        l_0x1015_9e86:
            ii(0x1015_9e86, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1015_9e89, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1015_9e8c, 5); call(0x1015_8bbb, -0x12d6);             /* call 0x10158bbb */
            ii(0x1015_9e91, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_9e93, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_9e94, 1); pop(edi);                               /* pop edi */
            ii(0x1015_9e95, 1); pop(esi);                               /* pop esi */
            ii(0x1015_9e96, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_9e97, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_9e98, 1); ret();                                  /* ret */
        }
    }
}
