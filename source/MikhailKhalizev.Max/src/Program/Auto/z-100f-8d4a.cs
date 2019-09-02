using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_8d4a-e203510a")]
        public void Method_100f_8d4a()
        {
            ii(0x100f_8d4a, 5); push(0x24);                             /* push 0x24 */
            ii(0x100f_8d4f, 5); call(Definitions.sys_check_available_stack_size, 0x6_cffe); /* call 0x10165d52 */
            ii(0x100f_8d54, 1); push(ebx);                              /* push ebx */
            ii(0x100f_8d55, 1); push(ecx);                              /* push ecx */
            ii(0x100f_8d56, 1); push(esi);                              /* push esi */
            ii(0x100f_8d57, 1); push(edi);                              /* push edi */
            ii(0x100f_8d58, 1); push(ebp);                              /* push ebp */
            ii(0x100f_8d59, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_8d5b, 6); sub(esp, 8);                            /* sub esp, 0x8 */
            ii(0x100f_8d61, 3); mov(memd[ss, ebp - 8], eax);            /* mov [ebp-0x8], eax */
            ii(0x100f_8d64, 3); mov(memd[ss, ebp - 4], edx);            /* mov [ebp-0x4], edx */
            ii(0x100f_8d67, 3); mov(eax, memd[ss, ebp - 4]);            /* mov eax, [ebp-0x4] */
            ii(0x100f_8d6a, 4); cmp(memb[ds, eax + 0x3d], 0x1a);        /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_8d6e, 2); if(jnz(0x100f_8da7, 0x37)) goto l_0x100f_8da7; /* jnz 0x100f8da7 */
            ii(0x100f_8d70, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_8d75, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8d7a, 5); call(0x1013_dc59, 0x4_4eda);            /* call 0x1013dc59 */
            ii(0x100f_8d7f, 5); call(0x100c_aa00, -0x2_e384);           /* call 0x100caa00 */
            ii(0x100f_8d84, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8d89, 1); push(eax);                              /* push eax */
            ii(0x100f_8d8a, 5); call(0x100c_aa20, -0x2_e36f);           /* call 0x100caa20 */
            ii(0x100f_8d8f, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8d91, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8d93, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_8d98, 5); mov(eax, StringDefinitions.UnableToReloadDisabledUnits); /* mov eax, 0x101a2697 */
            ii(0x100f_8d9d, 5); call(0x1011_5d23, 0x1_cf81);            /* call 0x10115d23 */
            ii(0x100f_8da2, 5); jmp(0x100f_8e40, 0x99); goto l_0x100f_8e40; /* jmp 0x100f8e40 */
        l_0x100f_8da7:
            ii(0x100f_8da7, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8daa, 3); mov(eax, memd[ds, eax + 0x50]);         /* mov eax, [eax+0x50] */
            ii(0x100f_8dad, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_8db0, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_8db2, 2); if(jnz(0x100f_8de8, 0x34)) goto l_0x100f_8de8; /* jnz 0x100f8de8 */
            ii(0x100f_8db4, 5); mov(edx, 0x4e4);                        /* mov edx, 0x4e4 */
            ii(0x100f_8db9, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8dbe, 5); call(0x1013_dc59, 0x4_4e96);            /* call 0x1013dc59 */
            ii(0x100f_8dc3, 5); call(0x100c_aa00, -0x2_e3c8);           /* call 0x100caa00 */
            ii(0x100f_8dc8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8dcd, 1); push(eax);                              /* push eax */
            ii(0x100f_8dce, 5); call(0x100c_aa20, -0x2_e3b3);           /* call 0x100caa20 */
            ii(0x100f_8dd3, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8dd5, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8dd7, 5); mov(edx, 1);                            /* mov edx, 0x1 */
            ii(0x100f_8ddc, 5); mov(eax, StringDefinitions.InsufficientMaterialInStorageToReloadUnit); /* mov eax, 0x101a26b8 */
            ii(0x100f_8de1, 5); call(0x1011_5d23, 0x1_cf3d);            /* call 0x10115d23 */
            ii(0x100f_8de6, 2); jmp(0x100f_8e40, 0x58); goto l_0x100f_8e40; /* jmp 0x100f8e40 */
        l_0x100f_8de8:
            ii(0x100f_8de8, 3); mov(edx, memd[ss, ebp - 4]);            /* mov edx, [ebp-0x4] */
            ii(0x100f_8deb, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8dee, 5); call(0x1008_a998, -0x6_e45b);           /* call 0x1008a998 */
            ii(0x100f_8df3, 5); call(0x100c_aa00, -0x2_e3f8);           /* call 0x100caa00 */
            ii(0x100f_8df8, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x100f_8dfd, 1); push(eax);                              /* push eax */
            ii(0x100f_8dfe, 5); call(0x100c_aa20, -0x2_e3e3);           /* call 0x100caa20 */
            ii(0x100f_8e03, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8e05, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_8e07, 5); mov(esi, StringDefinitions.UnitResuppliedWithAmmunition); /* mov esi, 0x101a26e9 */
            ii(0x100f_8e0c, 2); mov(ecx, eax);                          /* mov ecx, eax */
            ii(0x100f_8e0e, 2); mov(eax, esi);                          /* mov eax, esi */
            ii(0x100f_8e10, 5); call(0x1011_5d23, 0x1_cf0e);            /* call 0x10115d23 */
            ii(0x100f_8e15, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_8e17, 5); mov(edx, 0x13);                         /* mov edx, 0x13 */
            ii(0x100f_8e1c, 3); mov(eax, memd[ss, ebp - 8]);            /* mov eax, [ebp-0x8] */
            ii(0x100f_8e1f, 5); call(0x1016_3053, 0x6_a22f);            /* call 0x10163053 */
            ii(0x100f_8e24, 5); call(0x100d_5470, -0x2_39b9);           /* call 0x100d5470 */
            ii(0x100f_8e29, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100f_8e2c, 5); mov(ebx, 0x3e3);                        /* mov ebx, 0x3e3 */
            ii(0x100f_8e31, 5); mov(edx, 0x3e2);                        /* mov edx, 0x3e2 */
            ii(0x100f_8e36, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x100f_8e3b, 5); call(0x1013_daea, 0x4_4caa);            /* call 0x1013daea */
        l_0x100f_8e40:
            ii(0x100f_8e40, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_8e42, 1); pop(ebp);                               /* pop ebp */
            ii(0x100f_8e43, 1); pop(edi);                               /* pop edi */
            ii(0x100f_8e44, 1); pop(esi);                               /* pop esi */
            ii(0x100f_8e45, 1); pop(ecx);                               /* pop ecx */
            ii(0x100f_8e46, 1); pop(ebx);                               /* pop ebx */
            ii(0x100f_8e47, 1); ret();                                  /* ret */
        }
    }
}
