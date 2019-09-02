using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_8e48-d7370929")]
        public void Method_100f_8e48()
        {
            ii(0x100f_8e48, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_8e4d, 5); call(Definitions.sys_check_available_stack_size, 0x6_cf00); /* call 0x10165d52 */
            ii(0x100f_8e52, 1); push(ebx);                              /* push ebx */
            ii(0x100f_8e53, 1); push(ecx);                              /* push ecx */
            ii(0x100f_8e54, 1); push(esi);                              /* push esi */
            ii(0x100f_8e55, 1); push(edi);                              /* push edi */
            ii(0x100f_8e56, 1); push(ebp);                              /* push ebp */
            ii(0x100f_8e57, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_8e59, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100f_8e5f, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_8e62, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_8e65, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_8e68, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_8e6c, 2); if(jnz(0x100f_8ea5, 0x37)) goto l_0x100f_8ea5; /* jnz 0x100f8ea5 */
            ii(0x100f_8e6e, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_8e73, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8e78, 5); call(0x1013_dc59, 0x4_4ddc);            /* call 0x1013dc59 */
            ii(0x100f_8e7d, 5); call(0x100c_aa00, -0x2_e482);           /* call 0x100caa00 */
            ii(0x100f_8e82, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8e87, 1); push(eax);                              /* push eax */
            ii(0x100f_8e88, 5); call(0x100c_aa20, -0x2_e46d);           /* call 0x100caa20 */
            ii(0x100f_8e8d, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8e8f, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8e91, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_8e96, 5); mov(eax, StringDefinitions.UnableToRepairDisabledUnits); /* mov eax, 0x101a270a */
            ii(0x100f_8e9b, 5); call(0x1011_5d23, 0x1_ce83);            /* call 0x10115d23 */
            ii(0x100f_8ea0, 5); jmp(0x100f_8f3e, 0x99); goto l_0x100f_8f3e; /* jmp 0x100f8f3e */
        l_0x100f_8ea5:
            ii(0x100f_8ea5, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8ea8, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100f_8eab, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_8eae, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_8eb0, 2); if(jnz(0x100f_8ee6, 0x34)) goto l_0x100f_8ee6; /* jnz 0x100f8ee6 */
            ii(0x100f_8eb2, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_8eb7, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8ebc, 5); call(0x1013_dc59, 0x4_4d98);            /* call 0x1013dc59 */
            ii(0x100f_8ec1, 5); call(0x100c_aa00, -0x2_e4c6);           /* call 0x100caa00 */
            ii(0x100f_8ec6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8ecb, 1); push(eax);                              /* push eax */
            ii(0x100f_8ecc, 5); call(0x100c_aa20, -0x2_e4b1);           /* call 0x100caa20 */
            ii(0x100f_8ed1, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8ed3, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8ed5, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_8eda, 5); mov(eax, StringDefinitions.InsufficientMaterialInStorageToRepairUnit); /* mov eax, 0x101a272b */
            ii(0x100f_8edf, 5); call(0x1011_5d23, 0x1_ce3f);            /* call 0x10115d23 */
            ii(0x100f_8ee4, 2); jmp(0x100f_8f3e, 0x58); goto l_0x100f_8f3e; /* jmp 0x100f8f3e */
        l_0x100f_8ee6:
            ii(0x100f_8ee6, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_8ee9, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8eec, 5); call(0x1008_a998, -0x6_e559);           /* call 0x1008a998 */
            ii(0x100f_8ef1, 5); call(0x100c_aa00, -0x2_e4f6);           /* call 0x100caa00 */
            ii(0x100f_8ef6, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8efb, 1); push(eax);                              /* push eax */
            ii(0x100f_8efc, 5); call(0x100c_aa20, -0x2_e4e1);           /* call 0x100caa20 */
            ii(0x100f_8f01, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8f03, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_8f05, 5); mov(esi, StringDefinitions.UnitRepaired); /* mov esi, 0x101a275c */
            ii(0x100f_8f0a, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8f0c, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_8f0e, 5); call(0x1011_5d23, 0x1_ce10);            /* call 0x10115d23 */
            ii(0x100f_8f13, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8f15, 5); mov(edx, 0x11);                         /* mov edx, 0x11 */
            ii(0x100f_8f1a, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8f1d, 5); call(0x1016_3053, 0x6_a131);            /* call 0x10163053 */
            ii(0x100f_8f22, 5); call(0x100d_5470, -0x2_3ab7);           /* call 0x100d5470 */
            ii(0x100f_8f27, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_8f2a, 5); mov(ebx, 0x3ed);                        /* mov ebx, 0x3ed */
            ii(0x100f_8f2f, 5); mov(edx, 0x3ec);                        /* mov edx, 0x3ec */
            ii(0x100f_8f34, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8f39, 5); call(0x1013_daea, 0x4_4bac);            /* call 0x1013daea */
        l_0x100f_8f3e:
            ii(0x100f_8f3e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_8f40, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_8f41, 1); pop(edi);                               /* pop edi */
            ii(0x100f_8f42, 1); pop(esi);                               /* pop esi */
            ii(0x100f_8f43, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_8f44, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_8f45, 1); ret();                                  /* ret */
        }
    }
}
