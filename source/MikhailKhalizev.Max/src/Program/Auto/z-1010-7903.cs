using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_7903-73d39b93")]
        public void Method_1010_7903()
        {
            ii(0x1010_7903, 5); push(0x54);                             /* push 0x54 */
            ii(0x1010_7908, 5); call(Definitions.sys_check_available_stack_size, 0x5_e445); /* call 0x10165d52 */
            ii(0x1010_790d, 1); push(ebx);                              /* push ebx */
            ii(0x1010_790e, 1); push(ecx);                              /* push ecx */
            ii(0x1010_790f, 1); push(edx);                              /* push edx */
            ii(0x1010_7910, 1); push(esi);                              /* push esi */
            ii(0x1010_7911, 1); push(edi);                              /* push edi */
            ii(0x1010_7912, 1); push(ebp);                              /* push ebp */
            ii(0x1010_7913, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_7915, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x1010_791b, 7); cmp(memb[ds, 0x101c_4d96], 0);          /* cmp byte [0x101c4d96], 0x0 */
            ii(0x1010_7922, 2); if(jz(0x1010_7959, 0x35)) goto l_0x1010_7959; /* jz 0x10107959 */
            ii(0x1010_7924, 7); mov(memb[ds, 0x101c_4d96], 0);          /* mov byte [0x101c4d96], 0x0 */
            ii(0x1010_792b, 5); mov(ebx, 0x32);                         /* mov ebx, 0x32 */
            ii(0x1010_7930, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1010_7932, 3); lea(eax, memd[ss, ebp - 0x34]);         /* lea eax, [ebp-0x34] */
            ii(0x1010_7935, 5); call(Definitions.sys_memset, 0x5_e4a6); /* call 0x10165de0 */
            ii(0x1010_793a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_793c, 6); mov(ax, memw[ds, 0x101c_4d94]);         /* mov ax, [0x101c4d94] */
            ii(0x1010_7942, 3); mov(memd[ss, ebp - 0x20], eax);         /* mov [ebp-0x20], eax */
            ii(0x1010_7945, 7); mov(memd[ss, ebp - 0x24], 1);           /* mov dword [ebp-0x24], 0x1 */
            ii(0x1010_794c, 3); lea(edx, memd[ss, ebp - 0x34]);         /* lea edx, [ebp-0x34] */
            ii(0x1010_794f, 5); mov(eax, 0x7a);                         /* mov eax, 0x7a */
            ii(0x1010_7954, 5); call(0x100e_44ba, -0x2_349f);           /* call 0x100e44ba */
        l_0x1010_7959:
            ii(0x1010_7959, 5); mov(edx, 0x4ec0);                       /* mov edx, 0x4ec0 */
            ii(0x1010_795e, 5); mov(eax, memd[ds, 0x101c_4dac]);        /* mov eax, [0x101c4dac] */
            ii(0x1010_7963, 5); call(0x100e_464c, -0x2_331c);           /* call 0x100e464c */
            ii(0x1010_7968, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_796a, 6); mov(ax, memw[ds, 0x101c_4db4]);         /* mov ax, [0x101c4db4] */
            ii(0x1010_7970, 5); call(0x100e_4467, -0x2_350e);           /* call 0x100e4467 */
            ii(0x1010_7975, 7); cmp(memb[ds, 0x101c_4d97], 0);          /* cmp byte [0x101c4d97], 0x0 */
            ii(0x1010_797c, 2); if(jz(0x1010_79c3, 0x45)) goto l_0x1010_79c3; /* jz 0x101079c3 */
            ii(0x1010_797e, 4); mov(memb[ss, ebp - 0x38], 0);           /* mov byte [ebp-0x38], 0x0 */
            ii(0x1010_7982, 2); jmp(0x1010_798a, 6); goto l_0x1010_798a; /* jmp 0x1010798a */
        l_0x1010_7984:
            ii(0x1010_7984, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1010_7987, 3); inc(memb[ss, ebp - 0x38]);              /* inc byte [ebp-0x38] */
        l_0x1010_798a:
            ii(0x1010_798a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_798c, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1010_798f, 3); cmp(eax, 4);                            /* cmp eax, 0x4 */
            ii(0x1010_7992, 2); if(jge(0x1010_79bc, 0x28)) goto l_0x1010_79bc; /* jge 0x101079bc */
            ii(0x1010_7994, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_7996, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1010_7999, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_799c, 6); mov(eax, memd[ds, eax + 0x101c_4140]);  /* mov eax, [eax+0x101c4140] */
            ii(0x1010_79a2, 5); call(Definitions.sys_free, 0x6_371a);   /* call 0x1016b0c1 */
            ii(0x1010_79a7, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1010_79a9, 3); mov(al, memb[ss, ebp - 0x38]);          /* mov al, [ebp-0x38] */
            ii(0x1010_79ac, 3); shl(eax, 2);                            /* shl eax, 0x2 */
            ii(0x1010_79af, 6); mov(eax, memd[ds, eax + 0x101c_4150]);  /* mov eax, [eax+0x101c4150] */
            ii(0x1010_79b5, 5); call(Definitions.sys_free, 0x6_3707);   /* call 0x1016b0c1 */
            ii(0x1010_79ba, 2); jmp(0x1010_7984, -0x38); goto l_0x1010_7984; /* jmp 0x10107984 */
        l_0x1010_79bc:
            ii(0x1010_79bc, 7); mov(memb[ds, 0x101c_4d97], 0);          /* mov byte [0x101c4d97], 0x0 */
        l_0x1010_79c3:
            ii(0x1010_79c3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_79c5, 1); pop(ebp);                               /* pop ebp */
            ii(0x1010_79c6, 1); pop(edi);                               /* pop edi */
            ii(0x1010_79c7, 1); pop(esi);                               /* pop esi */
            ii(0x1010_79c8, 1); pop(edx);                               /* pop edx */
            ii(0x1010_79c9, 1); pop(ecx);                               /* pop ecx */
            ii(0x1010_79ca, 1); pop(ebx);                               /* pop ebx */
            ii(0x1010_79cb, 1); ret();                                  /* ret */
        }
    }
}
