using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_c365-68651711")]
        public void Method_100e_c365()
        {
            ii(0x100e_c365, 5); push(0x24);                             /* push 0x24 */
            ii(0x100e_c36a, 5); call(Definitions.sys_check_available_stack_size, 0x7_99e3); /* call 0x10165d52 */
            ii(0x100e_c36f, 1); push(ebx);                              /* push ebx */
            ii(0x100e_c370, 1); push(ecx);                              /* push ecx */
            ii(0x100e_c371, 1); push(esi);                              /* push esi */
            ii(0x100e_c372, 1); push(edi);                              /* push edi */
            ii(0x100e_c373, 1); push(ebp);                              /* push ebp */
            ii(0x100e_c374, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_c376, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100e_c37c, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_c37f, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_c382, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c386, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_c38c, 4); movsx(edx, memw[ss, ebp - 0x4]);        /* movsx edx, word [ebp-0x4] */
            ii(0x100e_c390, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100e_c396, 6); mov(eax, memd[ds, eax + 0x101c_a550]);  /* mov eax, [eax+0x101ca550] */
            ii(0x100e_c39c, 6); cmp(eax, memd[ds, edx + 0x101c_a550]);  /* cmp eax, [edx+0x101ca550] */
            ii(0x100e_c3a2, 2); if(jge(0x100e_c3ad, 0x9)) goto l_0x100e_c3ad; /* jge 0x100ec3ad */
            ii(0x100e_c3a4, 7); mov(memd[ss, ebp - 0xc], 0xffff_ffff);  /* mov dword [ebp-0xc], 0xffffffff */
            ii(0x100e_c3ab, 2); jmp(0x100e_c3f1, 0x44); goto l_0x100e_c3f1; /* jmp 0x100ec3f1 */
        l_0x100e_c3ad:
            ii(0x100e_c3ad, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c3b1, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100e_c3b7, 4); movsx(edx, memw[ss, ebp - 0x8]);        /* movsx edx, word [ebp-0x8] */
            ii(0x100e_c3bb, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100e_c3c1, 6); mov(eax, memd[ds, eax + 0x101c_a550]);  /* mov eax, [eax+0x101ca550] */
            ii(0x100e_c3c7, 6); cmp(eax, memd[ds, edx + 0x101c_a550]);  /* cmp eax, [edx+0x101ca550] */
            ii(0x100e_c3cd, 2); if(jge(0x100e_c3d8, 0x9)) goto l_0x100e_c3d8; /* jge 0x100ec3d8 */
            ii(0x100e_c3cf, 7); mov(memd[ss, ebp - 0xc], 0x1);          /* mov dword [ebp-0xc], 0x1 */
            ii(0x100e_c3d6, 2); jmp(0x100e_c3f1, 0x19); goto l_0x100e_c3f1; /* jmp 0x100ec3f1 */
        l_0x100e_c3d8:
            ii(0x100e_c3d8, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x100e_c3dc, 5); call(0x100e_c30b, -0xd6);               /* call 0x100ec30b */
            ii(0x100e_c3e1, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100e_c3e3, 4); movsx(eax, memw[ss, ebp - 0x4]);        /* movsx eax, word [ebp-0x4] */
            ii(0x100e_c3e7, 5); call(0x100e_c30b, -0xe1);               /* call 0x100ec30b */
            ii(0x100e_c3ec, 2); sub(edx, eax);                          /* sub edx, eax */
            ii(0x100e_c3ee, 3); mov(memd[ss, ebp - 0xc], edx);          /* mov [ebp-0xc], edx */
        l_0x100e_c3f1:
            ii(0x100e_c3f1, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x100e_c3f4, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_c3f6, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_c3f7, 1); pop(edi);                               /* pop edi */
            ii(0x100e_c3f8, 1); pop(esi);                               /* pop esi */
            ii(0x100e_c3f9, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_c3fa, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_c3fb, 1); ret();                                  /* ret */
        }
    }
}
