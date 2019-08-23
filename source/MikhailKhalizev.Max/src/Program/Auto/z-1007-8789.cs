using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1007_8789-8f142fd1")]
        public void Method_1007_8789()
        {
            ii(0x1007_8789, 5); push(0x24);                             /* push 0x24 */
            ii(0x1007_878e, 5); call(Definitions.sys_check_available_stack_size, 0xe_d5bf); /* call 0x10165d52 */
            ii(0x1007_8793, 1); push(ebx);                              /* push ebx */
            ii(0x1007_8794, 1); push(ecx);                              /* push ecx */
            ii(0x1007_8795, 1); push(esi);                              /* push esi */
            ii(0x1007_8796, 1); push(edi);                              /* push edi */
            ii(0x1007_8797, 1); push(ebp);                              /* push ebp */
            ii(0x1007_8798, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_879a, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1007_87a0, 3); mov(memd[ss, ebp - 0x8], eax);          /* mov [ebp-0x8], eax */
            ii(0x1007_87a3, 3); mov(memd[ss, ebp - 0x4], edx);          /* mov [ebp-0x4], edx */
            ii(0x1007_87a6, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_87a9, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_87ac, 5); call(0x1007_78a5, -0xf0c);              /* call 0x100778a5 */
            ii(0x1007_87b1, 2); test(al, al);                           /* test al, al */
            ii(0x1007_87b3, 2); if(jnz(0x1007_87c7, 0x12)) goto l_0x1007_87c7; /* jnz 0x100787c7 */
            ii(0x1007_87b5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1007_87b7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_87ba, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_87bd, 5); call(0x1015_d211, 0xe_4a4f);            /* call 0x1015d211 */
            ii(0x1007_87c2, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1007_87c5, 2); jmp(0x1007_87f4, 0x2d); goto l_0x1007_87f4; /* jmp 0x100787f4 */
        l_0x1007_87c7:
            ii(0x1007_87c7, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_87ca, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1007_87cc, 3); mov(cl, memb[ds, edx + 0x4d]);          /* mov cl, [edx+0x4d] */
            ii(0x1007_87cf, 5); mov(ebx, 0x19);                         /* mov ebx, 0x19 */
            ii(0x1007_87d4, 3); mov(edx, memd[ss, ebp - 0x4]);          /* mov edx, [ebp-0x4] */
            ii(0x1007_87d7, 3); mov(eax, memd[ss, ebp - 0x8]);          /* mov eax, [ebp-0x8] */
            ii(0x1007_87da, 5); call(0x1015_c75a, 0xe_3f7b);            /* call 0x1015c75a */
            ii(0x1007_87df, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1007_87e2, 3); imul(edx, ecx);                         /* imul edx, ecx */
            ii(0x1007_87e5, 5); mov(ebx, 0x64);                         /* mov ebx, 0x64 */
            ii(0x1007_87ea, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x1007_87ec, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x1007_87ef, 2); idiv(ebx);                              /* idiv ebx */
            ii(0x1007_87f1, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
        l_0x1007_87f4:
            ii(0x1007_87f4, 3); mov(eax, memd[ss, ebp - 0xc]);          /* mov eax, [ebp-0xc] */
            ii(0x1007_87f7, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_87f9, 1); pop(ebp);                               /* pop ebp */
            ii(0x1007_87fa, 1); pop(edi);                               /* pop edi */
            ii(0x1007_87fb, 1); pop(esi);                               /* pop esi */
            ii(0x1007_87fc, 1); pop(ecx);                               /* pop ecx */
            ii(0x1007_87fd, 1); pop(ebx);                               /* pop ebx */
            ii(0x1007_87fe, 1); ret();                                  /* ret */
        }
    }
}
