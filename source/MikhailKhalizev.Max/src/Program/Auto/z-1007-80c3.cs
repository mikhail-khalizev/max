using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_80c3-75a25133")]
        public void Method_1007_80c3()
        {
            ii(0x1007_80c3, 5); push(0x30);                             /* push 0x30 */
            ii(0x1007_80c8, 5); call(Definitions.sys_check_available_stack_size, 0xe_dc85); /* call 0x10165d52 */
            ii(0x1007_80cd, 1); push(esi);                              /* push esi */
            ii(0x1007_80ce, 1); push(edi);                              /* push edi */
            ii(0x1007_80cf, 1); push(ebp);                              /* push ebp */
            ii(0x1007_80d0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_80d2, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1007_80d8, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1007_80db, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
            ii(0x1007_80de, 3); mov(memd[ss, ebp - 8], ebx);            /* mov [ebp-0x8], ebx */
            ii(0x1007_80e1, 3); mov(memb[ss, ebp - 4], cl);             /* mov [ebp-0x4], cl */
            ii(0x1007_80e4, 4); movsx(ebx, memb[ss, ebp - 4]);          /* movsx ebx, byte [ebp-0x4] */
            ii(0x1007_80e8, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_80eb, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_80ee, 3); mov(al, memb[ds, eax + 0x26]);          /* mov al, [eax+0x26] */
            ii(0x1007_80f1, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1007_80f6, 6); imul(eax, eax, 0xc5);                   /* imul eax, eax, 0xc5 */
            ii(0x1007_80fc, 5); mov(ecx, 0x101c_31c4);                  /* mov ecx, 0x101c31c4 */
            ii(0x1007_8101, 2); add(eax, ecx);                          /* add eax, ecx */
            ii(0x1007_8103, 5); call(0x100c_08dc, 0x4_87d4);            /* call 0x100c08dc */
            ii(0x1007_8108, 3); mov(memd[ss, ebp - 0x14], eax);         /* mov [ebp-0x14], eax */
            ii(0x1007_810b, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1007_810d, 3); mov(al, memb[ss, ebp + 0x10]);          /* mov al, [ebp+0x10] */
            ii(0x1007_8110, 1); push(eax);                              /* push eax */
            ii(0x1007_8111, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1007_8115, 1); push(eax);                              /* push eax */
            ii(0x1007_8116, 4); movsx(ecx, memb[ss, ebp - 4]);          /* movsx ecx, byte [ebp-0x4] */
            ii(0x1007_811a, 4); movsx(ebx, memw[ss, ebp - 8]);          /* movsx ebx, word [ebp-0x8] */
            ii(0x1007_811e, 3); mov(edx, memd[ss, ebp - 0xc]);          /* mov edx, [ebp-0xc] */
            ii(0x1007_8121, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1007_8124, 5); call(0x1007_7ff6, -0x133);              /* call 0x10077ff6 */
            ii(0x1007_8129, 3); mov(memb[ss, ebp - 0x18], al);          /* mov [ebp-0x18], al */
            ii(0x1007_812c, 3); mov(al, memb[ss, ebp - 0x18]);          /* mov al, [ebp-0x18] */
            ii(0x1007_812f, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_8131, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_8132, 1); pop(edi);                               /* pop edi */
            ii(0x1007_8133, 1); pop(esi);                               /* pop esi */
            ii(0x1007_8134, 3); ret(4);                                 /* ret 0x4 */
        }
    }
}
