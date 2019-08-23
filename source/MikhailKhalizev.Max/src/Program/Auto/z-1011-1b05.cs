using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1011_1b05-72525694")]
        public void Method_1011_1b05()
        {
            ii(0x1011_1b05, 5); push(0x48);                             /* push 0x48 */
            ii(0x1011_1b0a, 5); call(Definitions.sys_check_available_stack_size, 0x5_4243); /* call 0x10165d52 */
            ii(0x1011_1b0f, 1); push(ebx);                              /* push ebx */
            ii(0x1011_1b10, 1); push(ecx);                              /* push ecx */
            ii(0x1011_1b11, 1); push(edx);                              /* push edx */
            ii(0x1011_1b12, 1); push(esi);                              /* push esi */
            ii(0x1011_1b13, 1); push(edi);                              /* push edi */
            ii(0x1011_1b14, 1); push(ebp);                              /* push ebp */
            ii(0x1011_1b15, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_1b17, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x1011_1b1d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1011_1b20, 7); mov(memd[ss, ebp - 0x14], 0xa);         /* mov dword [ebp-0x14], 0xa */
            ii(0x1011_1b27, 7); mov(memd[ss, ebp - 0x10], 0x1d5);       /* mov dword [ebp-0x10], 0x1d5 */
            ii(0x1011_1b2e, 7); mov(memd[ss, ebp - 0xc], 0x276);        /* mov dword [ebp-0xc], 0x276 */
            ii(0x1011_1b35, 7); mov(memd[ss, ebp - 0x8], 0x1df);        /* mov dword [ebp-0x8], 0x1df */
            ii(0x1011_1b3c, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1011_1b41, 5); call(/* sys */ 0x1016_a24c, 0x5_8706);  /* call 0x1016a24c */
            ii(0x1011_1b46, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_1b48, 1); push(eax);                              /* push eax */
            ii(0x1011_1b49, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1011_1b4e, 1); push(eax);                              /* push eax */
            ii(0x1011_1b4f, 2); push(0);                                /* push 0x0 */
            ii(0x1011_1b51, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1011_1b54, 3); sub(eax, memd[ss, ebp - 0x10]);         /* sub eax, [ebp-0x10] */
            ii(0x1011_1b57, 1); cwde();                                 /* cwde */
            ii(0x1011_1b58, 1); push(eax);                              /* push eax */
            ii(0x1011_1b59, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1011_1b5c, 3); sub(eax, memd[ss, ebp - 0x14]);         /* sub eax, [ebp-0x14] */
            ii(0x1011_1b5f, 1); cwde();                                 /* cwde */
            ii(0x1011_1b60, 1); push(eax);                              /* push eax */
            ii(0x1011_1b61, 4); movsx(eax, memw[ss, ebp - 0x10]);       /* movsx eax, word [ebp-0x10] */
            ii(0x1011_1b65, 1); push(eax);                              /* push eax */
            ii(0x1011_1b66, 4); movsx(ecx, memw[ss, ebp - 0x14]);       /* movsx ecx, word [ebp-0x14] */
            ii(0x1011_1b6a, 5); mov(ebx, StringDefinitions.Copyright1996InterplayProductionsV104); /* mov ebx, 0x101a46db */
            ii(0x1011_1b6f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1b72, 3); mov(edx, memd[ds, eax + 0xe]);          /* mov edx, [eax+0xe] */
            ii(0x1011_1b75, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_1b78, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1011_1b7b, 3); mov(eax, memd[ds, eax + 0x16]);         /* mov eax, [eax+0x16] */
            ii(0x1011_1b7e, 5); call(0x100e_9ae5, -0x2_809e);           /* call 0x100e9ae5 */
            ii(0x1011_1b83, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_1b85, 1); pop(ebp);                               /* pop ebp */
            ii(0x1011_1b86, 1); pop(edi);                               /* pop edi */
            ii(0x1011_1b87, 1); pop(esi);                               /* pop esi */
            ii(0x1011_1b88, 1); pop(edx);                               /* pop edx */
            ii(0x1011_1b89, 1); pop(ecx);                               /* pop ecx */
            ii(0x1011_1b8a, 1); pop(ebx);                               /* pop ebx */
            ii(0x1011_1b8b, 1); ret();                                  /* ret */
        }
    }
}
