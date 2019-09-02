using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_3137-8f348a4a")]
        public void Method_100b_3137()
        {
            ii(0x100b_3137, 5); push(0x24);                             /* push 0x24 */
            ii(0x100b_313c, 5); call(Definitions.sys_check_available_stack_size, 0xb_2c11); /* call 0x10165d52 */
            ii(0x100b_3141, 1); push(ebx);                              /* push ebx */
            ii(0x100b_3142, 1); push(ecx);                              /* push ecx */
            ii(0x100b_3143, 1); push(esi);                              /* push esi */
            ii(0x100b_3144, 1); push(edi);                              /* push edi */
            ii(0x100b_3145, 1); push(ebp);                              /* push ebp */
            ii(0x100b_3146, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_3148, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_314e, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_3151, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_3154, 5); mov(edx, StringDefinitions.RetreatFromDanger); /* mov edx, 0x101a10cd */
            ii(0x100b_3159, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_315c, 5); call(Definitions.sys_strcpy, 0xb_2d6e); /* call 0x10165ecf */
            ii(0x100b_3161, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_3164, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x100b_3167, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100b_316a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_316c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_316d, 1); pop(edi);                               /* pop edi */
            ii(0x100b_316e, 1); pop(esi);                               /* pop esi */
            ii(0x100b_316f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_3170, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_3171, 1); ret();                                  /* ret */
        }
    }
}
