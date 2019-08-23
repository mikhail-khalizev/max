using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_6ec0-d8b0255f")]
        public void Method_1007_6ec0()
        {
            ii(0x1007_6ec0, 5); push(0x28);                             /* push 0x28 */
            ii(0x1007_6ec5, 5); call(Definitions.sys_check_available_stack_size, 0xe_ee88); /* call 0x10165d52 */
            ii(0x1007_6eca, 1); push(ebx);                              /* push ebx */
            ii(0x1007_6ecb, 1); push(ecx);                              /* push ecx */
            ii(0x1007_6ecc, 1); push(edx);                              /* push edx */
            ii(0x1007_6ecd, 1); push(esi);                              /* push esi */
            ii(0x1007_6ece, 1); push(edi);                              /* push edi */
            ii(0x1007_6ecf, 1); push(ebp);                              /* push ebp */
            ii(0x1007_6ed0, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_6ed2, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_6ed8, 3); mov(memd[ss, ebp - 0x4], eax);          /* mov [ebp-0x4], eax */
            ii(0x1007_6edb, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6ede, 5); call(0x1007_623c, -0xca7);              /* call 0x1007623c */
            ii(0x1007_6ee3, 4); mov(ax, memw[ds, eax + 0x12]);          /* mov ax, [eax+0x12] */
            ii(0x1007_6ee7, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_6eea, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6eed, 5); call(0x1007_623c, -0xcb6);              /* call 0x1007623c */
            ii(0x1007_6ef2, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_6ef5, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_6ef8, 3); cmp(eax, 0x4);                          /* cmp eax, 0x4 */
            ii(0x1007_6efb, 2); if(jg(0x1007_6f0e, 0x11)) goto l_0x1007_6f0e; /* jg 0x10076f0e */
            ii(0x1007_6efd, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6f00, 5); call(0x1007_623c, -0xcc9);              /* call 0x1007623c */
            ii(0x1007_6f05, 4); mov(ax, memw[ds, eax + 0x17]);          /* mov ax, [eax+0x17] */
            ii(0x1007_6f09, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_6f0c, 2); jmp(0x1007_6f51, 0x43); goto l_0x1007_6f51; /* jmp 0x10076f51 */
        l_0x1007_6f0e:
            ii(0x1007_6f0e, 4); movsx(eax, memw[ss, ebp - 0x8]);        /* movsx eax, word [ebp-0x8] */
            ii(0x1007_6f12, 3); cmp(eax, 0xa);                          /* cmp eax, 0xa */
            ii(0x1007_6f15, 2); if(jge(0x1007_6f21, 0xa)) goto l_0x1007_6f21; /* jge 0x10076f21 */
            ii(0x1007_6f17, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6f1a, 5); cmp(memw[ds, eax + 0x8], 0x42);         /* cmp word [eax+0x8], 0x42 */
            ii(0x1007_6f1f, 2); if(jnz(0x1007_6f23, 0x2)) goto l_0x1007_6f23; /* jnz 0x10076f23 */
        l_0x1007_6f21:
            ii(0x1007_6f21, 2); jmp(0x1007_6f2d, 0xa); goto l_0x1007_6f2d; /* jmp 0x10076f2d */
        l_0x1007_6f23:
            ii(0x1007_6f23, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6f26, 5); cmp(memw[ds, eax + 0x8], 0x47);         /* cmp word [eax+0x8], 0x47 */
            ii(0x1007_6f2b, 2); if(jnz(0x1007_6f2f, 0x2)) goto l_0x1007_6f2f; /* jnz 0x10076f2f */
        l_0x1007_6f2d:
            ii(0x1007_6f2d, 2); jmp(0x1007_6f42, 0x13); goto l_0x1007_6f42; /* jmp 0x10076f42 */
        l_0x1007_6f2f:
            ii(0x1007_6f2f, 3); mov(eax, memd[ss, ebp - 0x4]);          /* mov eax, [ebp-0x4] */
            ii(0x1007_6f32, 5); call(0x1007_623c, -0xcfb);              /* call 0x1007623c */
            ii(0x1007_6f37, 3); mov(eax, memd[ds, eax + 0x6]);          /* mov eax, [eax+0x6] */
            ii(0x1007_6f3a, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1007_6f3d, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1007_6f40, 2); if(jge(0x1007_6f4a, 0x8)) goto l_0x1007_6f4a; /* jge 0x10076f4a */
        l_0x1007_6f42:
            ii(0x1007_6f42, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_6f45, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_6f48, 2); jmp(0x1007_6f51, 0x7); goto l_0x1007_6f51; /* jmp 0x10076f51 */
        l_0x1007_6f4a:
            ii(0x1007_6f4a, 7); mov(memd[ss, ebp - 0xc], 0xa);          /* mov dword [ebp-0xc], 0xa */
        l_0x1007_6f51:
            ii(0x1007_6f51, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_6f54, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_6f56, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_6f57, 1); pop(edi);                               /* pop edi */
            ii(0x1007_6f58, 1); pop(esi);                               /* pop esi */
            ii(0x1007_6f59, 1); pop(edx);                               /* pop edx */
            ii(0x1007_6f5a, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_6f5b, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_6f5c, 1); ret();                                  /* ret */
        }
    }
}
