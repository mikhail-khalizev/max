using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100a_ffc8-6816a4eb")]
        public void Method_100a_ffc8()
        {
            ii(0x100a_ffc8, 5); push(0x20);                             /* push 0x20 */
            ii(0x100a_ffcd, 5); call(Definitions.sys_check_available_stack_size, 0xb_5d80); /* call 0x10165d52 */
            ii(0x100a_ffd2, 1); push(ecx);                              /* push ecx */
            ii(0x100a_ffd3, 1); push(esi);                              /* push esi */
            ii(0x100a_ffd4, 1); push(edi);                              /* push edi */
            ii(0x100a_ffd5, 1); push(ebp);                              /* push ebp */
            ii(0x100a_ffd6, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100a_ffd8, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100a_ffde, 3); mov(memd[ss, ebp - 12], eax);           /* mov [ebp-0xc], eax */
            ii(0x100a_ffe1, 3); mov(memd[ss, ebp - 8], edx);            /* mov [ebp-0x8], edx */
            ii(0x100a_ffe4, 3); mov(memb[ss, ebp - 4], bl);             /* mov [ebp-0x4], bl */
            ii(0x100a_ffe7, 3); mov(edx, memd[ss, ebp - 12]);           /* mov edx, [ebp-0xc] */
            ii(0x100a_ffea, 3); add(edx, 0x3c);                         /* add edx, 0x3c */
            ii(0x100a_ffed, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100a_fff0, 5); call(0x1007_6d98, -0x3_925d);           /* call 0x10076d98 */
            ii(0x100a_fff5, 2); test(al, al);                           /* test al, al */
            ii(0x100a_fff7, 2); if(jz(0x100b_0006, 0xd)) goto l_0x100b_0006; /* jz 0x100b0006 */
            ii(0x100a_fff9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100a_fffb, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100a_fffe, 3); add(eax, 0x3c);                         /* add eax, 0x3c */
            ii(0x100b_0001, 5); call(0x1009_c8f8, -0x1_370e);           /* call 0x1009c8f8 */
        l_0x100b_0006:
            ii(0x100b_0006, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0008, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_000b, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_000e, 5); call(0x1013_ad71, 0x8_ad5e);            /* call 0x1013ad71 */
            ii(0x100b_0013, 2); test(al, al);                           /* test al, al */
            ii(0x100b_0015, 2); if(jz(0x100b_0049, 0x32)) goto l_0x100b_0049; /* jz 0x100b0049 */
            ii(0x100b_0017, 4); cmp(memb[ss, ebp - 4], 0);              /* cmp byte [ebp-0x4], 0x0 */
            ii(0x100b_001b, 2); if(jnz(0x100b_0026, 9)) goto l_0x100b_0026; /* jnz 0x100b0026 */
            ii(0x100b_001d, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_0020, 4); cmp(memb[ds, eax + 69], 0);             /* cmp byte [eax+0x45], 0x0 */
            ii(0x100b_0024, 2); if(jnz(0x100b_0028, 2)) goto l_0x100b_0028; /* jnz 0x100b0028 */
        l_0x100b_0026:
            ii(0x100b_0026, 2); jmp(0x100b_0034, 0xc); goto l_0x100b_0034; /* jmp 0x100b0034 */
        l_0x100b_0028:
            ii(0x100b_0028, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_002a, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_002d, 5); call(0x100a_d02d, -0x3005);             /* call 0x100ad02d */
            ii(0x100b_0032, 2); jmp(0x100b_0049, 0x15); goto l_0x100b_0049; /* jmp 0x100b0049 */
        l_0x100b_0034:
            ii(0x100b_0034, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100b_0039, 3); mov(eax, memd[ss, ebp - 12]);           /* mov eax, [ebp-0xc] */
            ii(0x100b_003c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_003f, 5); call(0x1007_65d0, -0x3_9a74);           /* call 0x100765d0 */
            ii(0x100b_0044, 5); call(0x100a_297d, -0xd6cc);             /* call 0x100a297d */
        l_0x100b_0049:
            ii(0x100b_0049, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_004b, 1); pop(ebp);                               /* pop ebp */
            ii(0x100b_004c, 1); pop(edi);                               /* pop edi */
            ii(0x100b_004d, 1); pop(esi);                               /* pop esi */
            ii(0x100b_004e, 1); pop(ecx);                               /* pop ecx */
            ii(0x100b_004f, 1); ret();                                  /* ret */
        }
    }
}
