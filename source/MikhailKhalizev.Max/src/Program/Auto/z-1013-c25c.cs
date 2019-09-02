using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_c25c-7e5bd4c")]
        public void Method_1013_c25c()
        {
            ii(0x1013_c25c, 5); push(0x28);                             /* push 0x28 */
            ii(0x1013_c261, 5); call(Definitions.sys_check_available_stack_size, 0x2_9aec); /* call 0x10165d52 */
            ii(0x1013_c266, 1); push(ebx);                              /* push ebx */
            ii(0x1013_c267, 1); push(ecx);                              /* push ecx */
            ii(0x1013_c268, 1); push(esi);                              /* push esi */
            ii(0x1013_c269, 1); push(edi);                              /* push edi */
            ii(0x1013_c26a, 1); push(ebp);                              /* push ebp */
            ii(0x1013_c26b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_c26d, 6); sub(esp, 0x10);                         /* sub esp, 0x10 */
            ii(0x1013_c273, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x1013_c276, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x1013_c279, 4); cmp(memd[ss, ebp - 4], 0);              /* cmp dword [ebp-0x4], 0x0 */
            ii(0x1013_c27d, 2); if(jnz(0x1013_c28b, 0xc)) goto l_0x1013_c28b; /* jnz 0x1013c28b */
            ii(0x1013_c27f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c281, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c284, 5); call(0x100e_0dc8, -0x5_b4c1);           /* call 0x100e0dc8 */
            ii(0x1013_c289, 2); jmp(0x1013_c2f3, 0x68); goto l_0x1013_c2f3; /* jmp 0x1013c2f3 */
        l_0x1013_c28b:
            ii(0x1013_c28b, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c28e, 5); call(0x1013_c898, 0x605);               /* call 0x1013c898 */
            ii(0x1013_c293, 3); mov(memd[ss, ebp - 0xc], eax);          /* mov [ebp-0xc], eax */
            ii(0x1013_c296, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1013_c298, 4); mov(ax, memw[ss, ebp - 0xc]);           /* mov ax, [ebp-0xc] */
            ii(0x1013_c29c, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_c29e, 2); if(jle(0x1013_c2b0, 0x10)) goto l_0x1013_c2b0; /* jle 0x1013c2b0 */
            ii(0x1013_c2a0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c2a2, 4); mov(dx, memw[ss, ebp - 0xc]);           /* mov dx, [ebp-0xc] */
            ii(0x1013_c2a6, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c2a9, 5); call(0x1013_c12f, -0x17f);              /* call 0x1013c12f */
            ii(0x1013_c2ae, 2); jmp(0x1013_c2f3, 0x43); goto l_0x1013_c2f3; /* jmp 0x1013c2f3 */
        l_0x1013_c2b0:
            ii(0x1013_c2b0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c2b3, 3); add(eax, 4);                            /* add eax, 0x4 */
            ii(0x1013_c2b6, 5); call(0x1007_6b90, -0xc_572b);           /* call 0x10076b90 */
            ii(0x1013_c2bb, 1); inc(eax);                               /* inc eax */
            ii(0x1013_c2bc, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c2be, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1013_c2c1, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c2c4, 5); call(0x100e_0dc8, -0x5_b501);           /* call 0x100e0dc8 */
            ii(0x1013_c2c9, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x1013_c2cc, 3); mov(memd[ss, ebp - 0x10], eax);         /* mov [ebp-0x10], eax */
            ii(0x1013_c2cf, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c2d2, 3); mov(edx, memd[ds, eax + 2]);            /* mov edx, [eax+0x2] */
            ii(0x1013_c2d5, 3); mov(eax, memd[ss, ebp - 0x10]);         /* mov eax, [ebp-0x10] */
            ii(0x1013_c2d8, 3); call_abs(memd[ds, edx + 4]);            /* call dword [edx+0x4] */
            ii(0x1013_c2db, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_c2dd, 3); mov(dx, ax);                            /* mov dx, ax */
            ii(0x1013_c2e0, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c2e3, 5); call(0x100e_0dc8, -0x5_b520);           /* call 0x100e0dc8 */
            ii(0x1013_c2e8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x1013_c2eb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x1013_c2ee, 5); call(0x1013_c217, -0xdc);               /* call 0x1013c217 */
        l_0x1013_c2f3:
            ii(0x1013_c2f3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_c2f5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_c2f6, 1); pop(edi);                               /* pop edi */
            ii(0x1013_c2f7, 1); pop(esi);                               /* pop esi */
            ii(0x1013_c2f8, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_c2f9, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_c2fa, 1); ret();                                  /* ret */
        }
    }
}
