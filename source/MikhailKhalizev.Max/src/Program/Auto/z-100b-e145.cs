using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_e145-e4fde749")]
        public void Method_100b_e145()
        {
            ii(0x100b_e145, 5); push(0x28);                             /* push 0x28 */
            ii(0x100b_e14a, 5); call(Definitions.sys_check_available_stack_size, 0xa_7c03); /* call 0x10165d52 */
            ii(0x100b_e14f, 1); push(ebx);                              /* push ebx */
            ii(0x100b_e150, 1); push(ecx);                              /* push ecx */
            ii(0x100b_e151, 1); push(edx);                              /* push edx */
            ii(0x100b_e152, 1); push(esi);                              /* push esi */
            ii(0x100b_e153, 1); push(edi);                              /* push edi */
            ii(0x100b_e154, 1); push(ebp);                              /* push ebp */
            ii(0x100b_e155, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_e157, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_e15d, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x100b_e160, 5); mov(eax, memd[ds, 0x101c_31be]);        /* mov eax, [0x101c31be] */
            ii(0x100b_e165, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100b_e168, 3); cmp(eax, 0x2);                          /* cmp eax, 0x2 */
            ii(0x100b_e16b, 2); if(jnz(0x100b_e173, 0x6)) goto l_0x100b_e173; /* jnz 0x100be173 */
            ii(0x100b_e16d, 4); mov(memb[ss, ebp - 0x8], 0x1);          /* mov byte [ebp-0x8], 0x1 */
            ii(0x100b_e171, 2); jmp(0x100b_e192, 0x1f); goto l_0x100b_e192; /* jmp 0x100be192 */
        l_0x100b_e173:
            ii(0x100b_e173, 5); mov(eax, 0x101c_3180);                  /* mov eax, 0x101c3180 */
            ii(0x100b_e178, 5); call(0x100c_b5c8, 0xd44b);              /* call 0x100cb5c8 */
            ii(0x100b_e17d, 1); cwde();                                 /* cwde */
            ii(0x100b_e17e, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100b_e180, 2); if(jle(0x100b_e188, 0x6)) goto l_0x100b_e188; /* jle 0x100be188 */
            ii(0x100b_e182, 4); mov(memb[ss, ebp - 0xc], 0x1);          /* mov byte [ebp-0xc], 0x1 */
            ii(0x100b_e186, 2); jmp(0x100b_e18c, 0x4); goto l_0x100b_e18c; /* jmp 0x100be18c */
        l_0x100b_e188:
            ii(0x100b_e188, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
        l_0x100b_e18c:
            ii(0x100b_e18c, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100b_e18f, 3); mov(memb[ss, ebp - 0x8], al);           /* mov [ebp-0x8], al */
        l_0x100b_e192:
            ii(0x100b_e192, 3); mov(al, memb[ss, ebp - 0x8]);           /* mov al, [ebp-0x8] */
            ii(0x100b_e195, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_e197, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_e198, 1); pop(edi);                               /* pop edi */
            ii(0x100b_e199, 1); pop(esi);                               /* pop esi */
            ii(0x100b_e19a, 1); pop(edx);                               /* pop edx */
            ii(0x100b_e19b, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_e19c, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_e19d, 1); ret();                                  /* ret */
        }
    }
}
