using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_4e2c-ba970165")]
        public void Method_100b_4e2c()
        {
            ii(0x100b_4e2c, 5); push(0x20);                             /* push 0x20 */
            ii(0x100b_4e31, 5); call(Definitions.sys_check_available_stack_size, 0xb_0f1c); /* call 0x10165d52 */
            ii(0x100b_4e36, 1); push(ebx);                              /* push ebx */
            ii(0x100b_4e37, 1); push(ecx);                              /* push ecx */
            ii(0x100b_4e38, 1); push(esi);                              /* push esi */
            ii(0x100b_4e39, 1); push(edi);                              /* push edi */
            ii(0x100b_4e3a, 1); push(ebp);                              /* push ebp */
            ii(0x100b_4e3b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_4e3d, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100b_4e43, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100b_4e46, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100b_4e49, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4e4c, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_4e4f, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4e52, 5); call(0x1007_6d98, -0x3_e0bf);           /* call 0x10076d98 */
            ii(0x100b_4e57, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4e59, 2); if(jnz(0x100b_4e6d, 0x12)) goto l_0x100b_4e6d; /* jnz 0x100b4e6d */
            ii(0x100b_4e5b, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4e5e, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100b_4e61, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4e64, 5); call(0x1007_6d98, -0x3_e0d1);           /* call 0x10076d98 */
            ii(0x100b_4e69, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4e6b, 2); if(jz(0x100b_4ec3, 0x56)) goto l_0x100b_4ec3; /* jz 0x100b4ec3 */
        l_0x100b_4e6d:
            ii(0x100b_4e6d, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4e70, 3); add(edx, 0x13);                         /* add edx, 0x13 */
            ii(0x100b_4e73, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4e76, 5); call(0x1008_b4b4, -0x2_99c7);           /* call 0x1008b4b4 */
            ii(0x100b_4e7b, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4e7d, 2); if(jz(0x100b_4e94, 0x15)) goto l_0x100b_4e94; /* jz 0x100b4e94 */
            ii(0x100b_4e7f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_4e81, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4e84, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_4e87, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4e8a, 5); call(0x1007_6574, -0x3_e91b);           /* call 0x10076574 */
            ii(0x100b_4e8f, 5); call(0x1015_2962, 0x9_dace);            /* call 0x10152962 */
        l_0x100b_4e94:
            ii(0x100b_4e94, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4e97, 3); add(edx, 0x17);                         /* add edx, 0x17 */
            ii(0x100b_4e9a, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100b_4e9d, 5); call(0x1008_b4b4, -0x2_99ee);           /* call 0x1008b4b4 */
            ii(0x100b_4ea2, 2); test(al, al);                           /* test al, al */
            ii(0x100b_4ea4, 2); if(jz(0x100b_4ebb, 0x15)) goto l_0x100b_4ebb; /* jz 0x100b4ebb */
            ii(0x100b_4ea6, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100b_4ea8, 3); mov(edx, memd[ss, ebp - 8]);            /* mov edx, [ebp-0x8] */
            ii(0x100b_4eab, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_4eae, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4eb1, 5); call(0x1007_6574, -0x3_e942);           /* call 0x10076574 */
            ii(0x100b_4eb6, 5); call(0x1015_2962, 0x9_daa7);            /* call 0x10152962 */
        l_0x100b_4ebb:
            ii(0x100b_4ebb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100b_4ebe, 5); call(0x100b_4d3b, -0x188);              /* call 0x100b4d3b */
        l_0x100b_4ec3:
            ii(0x100b_4ec3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_4ec5, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_4ec6, 1); pop(edi);                               /* pop edi */
            ii(0x100b_4ec7, 1); pop(esi);                               /* pop esi */
            ii(0x100b_4ec8, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_4ec9, 1); pop(ebx);                               /* pop ebx */
            ii(0x100b_4eca, 1); ret();                                  /* ret */
        }
    }
}
