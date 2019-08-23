using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100e_2f04-5ed14360")]
        public void Method_100e_2f04()
        {
            ii(0x100e_2f04, 5); push(0x40);                             /* push 0x40 */
            ii(0x100e_2f09, 5); call(Definitions.sys_check_available_stack_size, 0x8_2e44); /* call 0x10165d52 */
            ii(0x100e_2f0e, 1); push(ebx);                              /* push ebx */
            ii(0x100e_2f0f, 1); push(ecx);                              /* push ecx */
            ii(0x100e_2f10, 1); push(esi);                              /* push esi */
            ii(0x100e_2f11, 1); push(edi);                              /* push edi */
            ii(0x100e_2f12, 1); push(ebp);                              /* push ebp */
            ii(0x100e_2f13, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100e_2f15, 6); sub(esp, 0x28);                         /* sub esp, 0x28 */
            ii(0x100e_2f1b, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x100e_2f1e, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x100e_2f21, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2f24, 5); call(0x1007_623c, -0x6_cced);           /* call 0x1007623c */
            ii(0x100e_2f29, 3); mov(edx, memd[ds, eax + 0x19]);         /* mov edx, [eax+0x19] */
            ii(0x100e_2f2c, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100e_2f2f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x100e_2f32, 3); mov(al, memb[ds, eax + 0x54]);          /* mov al, [eax+0x54] */
            ii(0x100e_2f35, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100e_2f3a, 2); cmp(eax, edx);                          /* cmp eax, edx */
            ii(0x100e_2f3c, 2); if(jl(0x100e_2f44, 0x6)) goto l_0x100e_2f44; /* jl 0x100e2f44 */
            ii(0x100e_2f3e, 4); mov(memb[ss, ebp - 0xc], 0);            /* mov byte [ebp-0xc], 0x0 */
            ii(0x100e_2f42, 2); jmp(0x100e_2f87, 0x43); goto l_0x100e_2f87; /* jmp 0x100e2f87 */
        l_0x100e_2f44:
            ii(0x100e_2f44, 3); lea(eax, ebp - 0x1c);                   /* lea eax, [ebp-0x1c] */
            ii(0x100e_2f47, 5); call(0x1007_20b1, -0x7_0e9b);           /* call 0x100720b1 */
            ii(0x100e_2f4c, 3); lea(eax, ebp - 0x28);                   /* lea eax, [ebp-0x28] */
            ii(0x100e_2f4f, 5); call(0x1007_20b1, -0x7_0ea3);           /* call 0x100720b1 */
            ii(0x100e_2f54, 3); lea(ebx, ebp - 0x28);                   /* lea ebx, [ebp-0x28] */
            ii(0x100e_2f57, 3); lea(edx, ebp - 0x1c);                   /* lea edx, [ebp-0x1c] */
            ii(0x100e_2f5a, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x100e_2f5d, 3); add(eax, 0x18);                         /* add eax, 0x18 */
            ii(0x100e_2f60, 5); call(0x1007_6574, -0x6_c9f1);           /* call 0x10076574 */
            ii(0x100e_2f65, 5); call(0x1007_6204, -0x6_cd66);           /* call 0x10076204 */
            ii(0x100e_2f6a, 5); call(0x1014_3616, 0x6_06a7);            /* call 0x10143616 */
            ii(0x100e_2f6f, 4); movsx(eax, memw[ss, ebp - 0x1a]);       /* movsx eax, word [ebp-0x1a] */
            ii(0x100e_2f73, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100e_2f75, 2); if(jle(0x100e_2f7d, 0x6)) goto l_0x100e_2f7d; /* jle 0x100e2f7d */
            ii(0x100e_2f77, 4); mov(memb[ss, ebp - 0x10], 0x1);         /* mov byte [ebp-0x10], 0x1 */
            ii(0x100e_2f7b, 2); jmp(0x100e_2f81, 0x4); goto l_0x100e_2f81; /* jmp 0x100e2f81 */
        l_0x100e_2f7d:
            ii(0x100e_2f7d, 4); mov(memb[ss, ebp - 0x10], 0);           /* mov byte [ebp-0x10], 0x0 */
        l_0x100e_2f81:
            ii(0x100e_2f81, 3); mov(al, memb[ss, ebp - 0x10]);          /* mov al, [ebp-0x10] */
            ii(0x100e_2f84, 3); mov(memb[ss, ebp - 0xc], al);           /* mov [ebp-0xc], al */
        l_0x100e_2f87:
            ii(0x100e_2f87, 3); mov(al, memb[ss, ebp - 0xc]);           /* mov al, [ebp-0xc] */
            ii(0x100e_2f8a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100e_2f8c, 1); pop(ebp);                               /* pop ebp */
            ii(0x100e_2f8d, 1); pop(edi);                               /* pop edi */
            ii(0x100e_2f8e, 1); pop(esi);                               /* pop esi */
            ii(0x100e_2f8f, 1); pop(ecx);                               /* pop ecx */
            ii(0x100e_2f90, 1); pop(ebx);                               /* pop ebx */
            ii(0x100e_2f91, 1); ret();                                  /* ret */
        }
    }
}
