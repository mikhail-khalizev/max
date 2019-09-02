using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1013_3bc5-295cef6")]
        public void Method_1013_3bc5()
        {
            ii(0x1013_3bc5, 5); push(0x34);                             /* push 0x34 */
            ii(0x1013_3bca, 5); call(Definitions.sys_check_available_stack_size, 0x3_2183); /* call 0x10165d52 */
            ii(0x1013_3bcf, 1); push(ebx);                              /* push ebx */
            ii(0x1013_3bd0, 1); push(ecx);                              /* push ecx */
            ii(0x1013_3bd1, 1); push(edx);                              /* push edx */
            ii(0x1013_3bd2, 1); push(esi);                              /* push esi */
            ii(0x1013_3bd3, 1); push(edi);                              /* push edi */
            ii(0x1013_3bd4, 1); push(ebp);                              /* push ebp */
            ii(0x1013_3bd5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1013_3bd7, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1013_3bdd, 3); mov(memd[ss, ebp - 4], eax);            /* mov [ebp-0x4], eax */
            ii(0x1013_3be0, 5); mov(ebx, 9);                            /* mov ebx, 0x9 */
            ii(0x1013_3be5, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1013_3be7, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_3bea, 5); call(Definitions.sys_memset, 0x3_21f1); /* call 0x10165de0 */
            ii(0x1013_3bef, 5); mov(ebx, 8);                            /* mov ebx, 0x8 */
            ii(0x1013_3bf4, 4); movsx(eax, memw[ss, ebp - 4]);          /* movsx eax, word [ebp-0x4] */
            ii(0x1013_3bf8, 3); shl(eax, 4);                            /* shl eax, 0x4 */
            ii(0x1013_3bfb, 6); mov(edx, memd[ds, Definitions.ptr_arr_meta]); /* mov edx, [0x101c70f0] */
            ii(0x1013_3c01, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1013_3c03, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_3c06, 5); call(Definitions.sys_strncpy, 0x3_e2d5); /* call 0x10171ee0 */
            ii(0x1013_3c0b, 7); mov(memd[ss, ebp - 0x14], 0);           /* mov dword [ebp-0x14], 0x0 */
            ii(0x1013_3c12, 2); jmp(0x1013_3c1a, 6); goto l_0x1013_3c1a; /* jmp 0x10133c1a */
        l_0x1013_3c14:
            ii(0x1013_3c14, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_3c17, 3); inc(memd[ss, ebp - 0x14]);              /* inc dword [ebp-0x14] */
        l_0x1013_3c1a:
            ii(0x1013_3c1a, 4); movsx(eax, memw[ss, ebp - 0x14]);       /* movsx eax, word [ebp-0x14] */
            ii(0x1013_3c1e, 5); cmp(eax, 0x787);                        /* cmp eax, 0x787 */
            ii(0x1013_3c23, 2); if(jge(0x1013_3c48, 0x23)) goto l_0x1013_3c48; /* jge 0x10133c48 */
            ii(0x1013_3c25, 4); movsx(edx, memw[ss, ebp - 0x14]);       /* movsx edx, word [ebp-0x14] */
            ii(0x1013_3c29, 3); shl(edx, 2);                            /* shl edx, 0x2 */
            ii(0x1013_3c2c, 6); mov(edx, memd[ds, edx + 0x101b_b520]);  /* mov edx, [edx+0x101bb520] */
            ii(0x1013_3c32, 3); lea(eax, memd[ss, ebp - 0x10]);         /* lea eax, [ebp-0x10] */
            ii(0x1013_3c35, 5); call(Definitions.sys_strcasecmp, 0x3_24f6); /* call 0x10166130 */
            ii(0x1013_3c3a, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1013_3c3c, 2); if(jnz(0x1013_3c46, 8)) goto l_0x1013_3c46; /* jnz 0x10133c46 */
            ii(0x1013_3c3e, 3); mov(eax, memd[ss, ebp - 0x14]);         /* mov eax, [ebp-0x14] */
            ii(0x1013_3c41, 3); mov(memd[ss, ebp - 0x18], eax);         /* mov [ebp-0x18], eax */
            ii(0x1013_3c44, 2); jmp(0x1013_3c4f, 9); goto l_0x1013_3c4f; /* jmp 0x10133c4f */
        l_0x1013_3c46:
            ii(0x1013_3c46, 2); jmp(0x1013_3c14, -0x34); goto l_0x1013_3c14; /* jmp 0x10133c14 */
        l_0x1013_3c48:
            ii(0x1013_3c48, 7); mov(memd[ss, ebp - 0x18], 0xffff_ffff); /* mov dword [ebp-0x18], 0xffffffff */
        l_0x1013_3c4f:
            ii(0x1013_3c4f, 3); mov(eax, memd[ss, ebp - 0x18]);         /* mov eax, [ebp-0x18] */
            ii(0x1013_3c52, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1013_3c54, 1); pop(ebp);                               /* pop ebp */
            ii(0x1013_3c55, 1); pop(edi);                               /* pop edi */
            ii(0x1013_3c56, 1); pop(esi);                               /* pop esi */
            ii(0x1013_3c57, 1); pop(edx);                               /* pop edx */
            ii(0x1013_3c58, 1); pop(ecx);                               /* pop ecx */
            ii(0x1013_3c59, 1); pop(ebx);                               /* pop ebx */
            ii(0x1013_3c5a, 1); ret();                                  /* ret */
        }
    }
}
