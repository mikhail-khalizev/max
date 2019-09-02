using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1015_2b8c-fbd885e7")]
        public void Method_1015_2b8c()
        {
            ii(0x1015_2b8c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1015_2b91, 5); call(Definitions.sys_check_available_stack_size, 0x1_31bc); /* call 0x10165d52 */
            ii(0x1015_2b96, 1); push(ebx);                              /* push ebx */
            ii(0x1015_2b97, 1); push(ecx);                              /* push ecx */
            ii(0x1015_2b98, 1); push(edx);                              /* push edx */
            ii(0x1015_2b99, 1); push(esi);                              /* push esi */
            ii(0x1015_2b9a, 1); push(edi);                              /* push edi */
            ii(0x1015_2b9b, 1); push(ebp);                              /* push ebp */
            ii(0x1015_2b9c, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_2b9e, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1015_2ba4, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1015_2ba7, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_2baa, 3); mov(eax, memd[ds, eax + 6]);            /* mov eax, [eax+0x6] */
            ii(0x1015_2bad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1015_2bb0, 3); cmp(eax, 0x27);                         /* cmp eax, 0x27 */
            ii(0x1015_2bb3, 2); if(jz(0x1015_2bbb, 6)) goto l_0x1015_2bbb; /* jz 0x10152bbb */
            ii(0x1015_2bb5, 4); mov(memb[ss, ebp - 8], 0);              /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_2bb9, 2); jmp(0x1015_2bde, 0x23); goto l_0x1015_2bde; /* jmp 0x10152bde */
        l_0x1015_2bbb:
            ii(0x1015_2bbb, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_2bbe, 7); mov(dx, memw[ds, eax + 213]);           /* mov dx, [eax+0xd5] */
            ii(0x1015_2bc5, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1015_2bc8, 4); cmp(dx, memw[ds, eax + 51]);            /* cmp dx, [eax+0x33] */
            ii(0x1015_2bcc, 2); if(jz(0x1015_2bd4, 6)) goto l_0x1015_2bd4; /* jz 0x10152bd4 */
            ii(0x1015_2bce, 4); mov(memb[ss, ebp - 12], 1);             /* mov byte [ebp-0xc], 0x1 */
            ii(0x1015_2bd2, 2); jmp(0x1015_2bd8, 4); goto l_0x1015_2bd8; /* jmp 0x10152bd8 */
        l_0x1015_2bd4:
            ii(0x1015_2bd4, 4); mov(memb[ss, ebp - 12], 0);             /* mov byte [ebp-0xc], 0x0 */
        l_0x1015_2bd8:
            ii(0x1015_2bd8, 3); mov(al, memb[ss, ebp - 12]);            /* mov al, [ebp-0xc] */
            ii(0x1015_2bdb, 3); mov(memb[ss, ebp - 8], al);             /* mov [ebp-0x8], al */
        l_0x1015_2bde:
            ii(0x1015_2bde, 3); mov(al, memb[ss, ebp - 8]);             /* mov al, [ebp-0x8] */
            ii(0x1015_2be1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_2be3, 1); pop(ebp);                               /* pop ebp */
            ii(0x1015_2be4, 1); pop(edi);                               /* pop edi */
            ii(0x1015_2be5, 1); pop(esi);                               /* pop esi */
            ii(0x1015_2be6, 1); pop(edx);                               /* pop edx */
            ii(0x1015_2be7, 1); pop(ecx);                               /* pop ecx */
            ii(0x1015_2be8, 1); pop(ebx);                               /* pop ebx */
            ii(0x1015_2be9, 1); ret();                                  /* ret */
        }
    }
}
