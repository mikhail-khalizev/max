using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_70fb-5823ed80")]
        public void Method_1012_70fb()
        {
            ii(0x1012_70fb, 5); push(0x24);                             /* push 0x24 */
            ii(0x1012_7100, 5); call(Definitions.sys_check_available_stack_size, 0x3_ec4d); /* call 0x10165d52 */
            ii(0x1012_7105, 1); push(ecx);                              /* push ecx */
            ii(0x1012_7106, 1); push(esi);                              /* push esi */
            ii(0x1012_7107, 1); push(edi);                              /* push edi */
            ii(0x1012_7108, 1); push(ebp);                              /* push ebp */
            ii(0x1012_7109, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1012_710b, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1012_7111, 3); mov(memb[ss, ebp - 4], al);             /* mov [ebp-0x4], al */
            ii(0x1012_7114, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1012_7117, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1012_711a, 3); mov(al, memb[ss, ebp - 4]);             /* mov al, [ebp-0x4] */
            ii(0x1012_711d, 5); mov(memb[ds, 0x101c_5c1c], al);         /* mov [0x101c5c1c], al */
            ii(0x1012_7122, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_7128, 4); mov(ax, memw[ds, edx + 0xc]);           /* mov ax, [edx+0xc] */
            ii(0x1012_712c, 6); mov(memw[ds, 0x101c_5c1d], ax);         /* mov [0x101c5c1d], ax */
            ii(0x1012_7132, 9); mov(memw[ds, 0x101c_5c1f], 0xa);        /* mov word [0x101c5c1f], 0xa */
            ii(0x1012_713b, 7); mov(memd[ss, ebp - 0x10], 0x101c_5c21); /* mov dword [ebp-0x10], 0x101c5c21 */
            ii(0x1012_7142, 6); mov(edx, memd[ds, 0x101c_59cc]);        /* mov edx, [0x101c59cc] */
            ii(0x1012_7148, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1012_714a, 3); mov(al, memb[ds, edx + 0x11]);          /* mov al, [edx+0x11] */
            ii(0x1012_714d, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_7150, 3); mov(memw[ds, edx], ax);                 /* mov [edx], ax */
            ii(0x1012_7153, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1012_7156, 3); mov(edx, memd[ss, ebp - 0x10]);         /* mov edx, [ebp-0x10] */
            ii(0x1012_7159, 4); mov(memw[ds, edx + 2], ax);             /* mov [edx+0x2], ax */
            ii(0x1012_715d, 5); mov(ebx, 6);                            /* mov ebx, 0x6 */
            ii(0x1012_7162, 5); call(0x1010_7757, -0x1_fa10);           /* call 0x10107757 */
            ii(0x1012_7167, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1012_7169, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1012_716c, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1012_716f, 5); call(Definitions.sys_memcpy, 0x3_ecd7); /* call 0x10165e4b */
            ii(0x1012_7174, 4); movsx(eax, memw[ss, ebp - 8]);          /* movsx eax, word [ebp-0x8] */
            ii(0x1012_7178, 5); call(0x1012_5be9, -0x1594);             /* call 0x10125be9 */
            ii(0x1012_717d, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1012_717f, 1); pop(ebp);                               /* pop ebp */
            ii(0x1012_7180, 1); pop(edi);                               /* pop edi */
            ii(0x1012_7181, 1); pop(esi);                               /* pop esi */
            ii(0x1012_7182, 1); pop(ecx);                               /* pop ecx */
            ii(0x1012_7183, 1); ret();                                  /* ret */
        }
    }
}
