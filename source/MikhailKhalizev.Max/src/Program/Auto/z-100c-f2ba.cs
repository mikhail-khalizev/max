using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0cada6b7-630b-47fa-92f3-0e07aa5a7465")]
        public void Method_100c_f2ba()
        {
            ii(0x100c_f2ba, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100c_f2bf, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6a8e); /* call 0x10165d52 */
            ii(0x100c_f2c4, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_f2c5, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f2c6, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f2c7, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f2c8, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f2c9, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f2cb, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f2d1, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_f2d4, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_f2d7, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f2da, 4); cmp(memd_a32[ds, eax + 0x14], 0);       /* cmp dword [eax+0x14], 0x0 */
            ii(0x100c_f2de, 2); if(jzd(0x100c_f30a, 0x2a)) goto l_0x100c_f30a; /* jz 0x100cf30a */
            ii(0x100c_f2e0, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f2e3, 3); mov(eax, memd_a32[ds, eax + 0x14]);     /* mov eax, [eax+0x14] */
            ii(0x100c_f2e6, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f2e9, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_f2ed, 2); if(jzd(0x100c_f303, 0x14)) goto l_0x100c_f303; /* jz 0x100cf303 */
            ii(0x100c_f2ef, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f2f1, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_f2f4, 5); calld(Definitions.my_dtor_d3, 0x8a3a);  /* call 0x100d7d33 */
            ii(0x100c_f2f9, 5); calld(Definitions.sys_delete, 0x9_6c66); /* call 0x10165f64 */
            ii(0x100c_f2fe, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_f301, 2); jmpd(0x100c_f30a, 0x7); goto l_0x100c_f30a; /* jmp 0x100cf30a */
        l_0x100c_f303:
            ii(0x100c_f303, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100c_f30a:
            ii(0x100c_f30a, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f30f, 5); calld(Definitions.sys_new, 0x9_6aec);   /* call 0x10165e00 */
            ii(0x100c_f314, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_f317, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f31a, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f31d, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_f321, 2); if(jzd(0x100c_f34c, 0x29)) goto l_0x100c_f34c; /* jz 0x100cf34c */
            ii(0x100c_f323, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f326, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x100c_f329, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f32c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f32f, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100c_f332, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f335, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_f339, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f33c, 5); calld(Definitions.my_ctor_c19, 0x891d); /* call 0x100d7c5e */
            ii(0x100c_f341, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f344, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_f347, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_f34a, 2); jmpd(0x100c_f352, 0x6); goto l_0x100c_f352; /* jmp 0x100cf352 */
        l_0x100c_f34c:
            ii(0x100c_f34c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_f34f, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100c_f352:
            ii(0x100c_f352, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_f355, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_f358, 3); mov(memd_a32[ds, edx + 0x14], eax);     /* mov [edx+0x14], eax */
            ii(0x100c_f35b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f35d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_f35e, 1); popd(edi);                              /* pop edi */
            ii(0x100c_f35f, 1); popd(esi);                              /* pop esi */
            ii(0x100c_f360, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_f361, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_f362, 1); retd(); return;                         /* ret */
        }
    }
}
