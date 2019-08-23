using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100c_f168-4bbd1ad2")]
        public void Method_100c_f168()
        {
            ii(0x100c_f168, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100c_f16d, 5); calld(Definitions.sys_check_available_stack_size, 0x9_6be0); /* call 0x10165d52 */
            ii(0x100c_f172, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_f173, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f174, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f175, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f176, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f177, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f179, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f17f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_f182, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_f185, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f188, 4); cmp(memd_a32[ds, eax + 0xc], 0);        /* cmp dword [eax+0xc], 0x0 */
            ii(0x100c_f18c, 2); if(jzd(0x100c_f1b8, 0x2a)) goto l_0x100c_f1b8; /* jz 0x100cf1b8 */
            ii(0x100c_f18e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f191, 3); mov(eax, memd_a32[ds, eax + 0xc]);      /* mov eax, [eax+0xc] */
            ii(0x100c_f194, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f197, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_f19b, 2); if(jzd(0x100c_f1b1, 0x14)) goto l_0x100c_f1b1; /* jz 0x100cf1b1 */
            ii(0x100c_f19d, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f19f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_f1a2, 5); calld(Definitions.my_dtor_d3, 0x8b8c);  /* call 0x100d7d33 */
            ii(0x100c_f1a7, 5); calld(Definitions.sys_delete, 0x9_6db8); /* call 0x10165f64 */
            ii(0x100c_f1ac, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_f1af, 2); jmpd(0x100c_f1b8, 0x7); goto l_0x100c_f1b8; /* jmp 0x100cf1b8 */
        l_0x100c_f1b1:
            ii(0x100c_f1b1, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100c_f1b8:
            ii(0x100c_f1b8, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f1bd, 5); calld(Definitions.sys_new, 0x9_6c3e);   /* call 0x10165e00 */
            ii(0x100c_f1c2, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_f1c5, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f1c8, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f1cb, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_f1cf, 2); if(jzd(0x100c_f1fa, 0x29)) goto l_0x100c_f1fa; /* jz 0x100cf1fa */
            ii(0x100c_f1d1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f1d4, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x100c_f1d7, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f1da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f1dd, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100c_f1e0, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f1e3, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_f1e7, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f1ea, 5); calld(Definitions.my_ctor_c19, 0x8a6f); /* call 0x100d7c5e */
            ii(0x100c_f1ef, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f1f2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_f1f5, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_f1f8, 2); jmpd(0x100c_f200, 0x6); goto l_0x100c_f200; /* jmp 0x100cf200 */
        l_0x100c_f1fa:
            ii(0x100c_f1fa, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_f1fd, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100c_f200:
            ii(0x100c_f200, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_f203, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_f206, 3); mov(memd_a32[ds, edx + 0xc], eax);      /* mov [edx+0xc], eax */
            ii(0x100c_f209, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f20b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_f20c, 1); popd(edi);                              /* pop edi */
            ii(0x100c_f20d, 1); popd(esi);                              /* pop esi */
            ii(0x100c_f20e, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_f20f, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_f210, 1); retd();                                 /* ret */
        }
    }
}
