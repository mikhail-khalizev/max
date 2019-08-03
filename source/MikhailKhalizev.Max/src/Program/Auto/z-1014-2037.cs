using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("da0d564e-b08f-4eca-8946-486b7fa189a1")]
        public void Method_1014_2037()
        {
            ii(0x1014_2037, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1014_203c, 5); calld(Definitions.sys_check_available_stack_size, 0x23d11); /* call 0x10165d52 */
            ii(0x1014_2041, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_2042, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_2043, 1); pushd(edx);                             /* push edx */
            ii(0x1014_2044, 1); pushd(esi);                             /* push esi */
            ii(0x1014_2045, 1); pushd(edi);                             /* push edi */
            ii(0x1014_2046, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_2047, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_2049, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1014_204f, 4); movsx(eax, memw_a32[ss, ebp + 0x20]);   /* movsx eax, word [ebp+0x20] */
            ii(0x1014_2053, 5); calld(Definitions.sys_new_arr, 0x23fb8); /* call 0x10166010 */
            ii(0x1014_2058, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_205b, 3); lea(eax, ebp + 0x28);                   /* lea eax, [ebp+0x28] */
            ii(0x1014_205e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_2061, 3); lea(ebx, ebp - 0x8);                    /* lea ebx, [ebp-0x8] */
            ii(0x1014_2064, 3); mov(edx, memd_a32[ss, ebp + 0x24]);     /* mov edx, [ebp+0x24] */
            ii(0x1014_2067, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_206a, 5); calld(/* sys */ 0x1018_0f0b, 0x3ee9c);  /* call 0x10180f0b */
            ii(0x1014_206f, 7); mov(memd_a32[ss, ebp - 0x8], 0);        /* mov dword [ebp-0x8], 0x0 */
            ii(0x1014_2076, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1014_2079, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1014_207b, 5); calld(Definitions.my_string_release, 0x39c); /* call 0x1014241c */
            ii(0x1014_2080, 5); mov(eax, 0xc);                          /* mov eax, 0xc */
            ii(0x1014_2085, 5); calld(Definitions.sys_new, 0x23d76);    /* call 0x10165e00 */
            ii(0x1014_208a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_208d, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_2090, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1014_2093, 4); cmp(memd_a32[ss, ebp - 0x10], 0);       /* cmp dword [ebp-0x10], 0x0 */
            ii(0x1014_2097, 2); if(jzd(0x1014_20af, 0x16)) goto l_0x1014_20af; /* jz 0x101420af */
            ii(0x1014_2099, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1014_209c, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_209f, 5); calld(Definitions.my_strobj_ctor_char_ptr, -0x908); /* call 0x1014179c */
            ii(0x1014_20a4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1014_20a7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1014_20aa, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1014_20ad, 2); jmpd(0x1014_20b5, 0x6); goto l_0x1014_20b5; /* jmp 0x101420b5 */
        l_0x1014_20af:
            ii(0x1014_20af, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1014_20b2, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x1014_20b5:
            ii(0x1014_20b5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1014_20b8, 3); mov(edx, memd_a32[ss, ebp + 0x1c]);     /* mov edx, [ebp+0x1c] */
            ii(0x1014_20bb, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1014_20bd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_20c0, 5); calld(Definitions.sys_delete_arr, 0x23f13); /* call 0x10165fd8 */
            ii(0x1014_20c5, 3); mov(eax, memd_a32[ss, ebp + 0x1c]);     /* mov eax, [ebp+0x1c] */
            ii(0x1014_20c8, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1014_20cb, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1014_20ce, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_20d0, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_20d1, 1); popd(edi);                              /* pop edi */
            ii(0x1014_20d2, 1); popd(esi);                              /* pop esi */
            ii(0x1014_20d3, 1); popd(edx);                              /* pop edx */
            ii(0x1014_20d4, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_20d5, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_20d6, 1); retd(); return;                         /* ret */
        }
    }
}
