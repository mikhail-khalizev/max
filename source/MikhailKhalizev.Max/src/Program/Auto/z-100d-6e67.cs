using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("18dae1e6-606c-4ef9-bc59-076525dd142f")]
        public void Method_100d_6e67()
        {
            ii(0x100d_6e67, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100d_6e6c, 5); calld(Definitions.sys_check_available_stack_size, 0x8_eee1); /* call 0x10165d52 */
            ii(0x100d_6e71, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_6e72, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_6e73, 1); pushd(esi);                             /* push esi */
            ii(0x100d_6e74, 1); pushd(edi);                             /* push edi */
            ii(0x100d_6e75, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_6e76, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_6e78, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x100d_6e7e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_6e81, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_6e84, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_6e8b, 2); if(jzd(0x100d_6ea4, 0x17)) goto l_0x100d_6ea4; /* jz 0x100d6ea4 */
            ii(0x100d_6e8d, 5); mov(edx, 0x101b_5ea0);                  /* mov edx, 0x101b5ea0 */
            ii(0x100d_6e92, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6e95, 5); calld(Definitions.sys_call_dtor_arr, 0x8_f11e); /* call 0x10165fb8 */
            ii(0x100d_6e9a, 5); calld(Definitions.sys_delete_arr, 0x8_f139); /* call 0x10165fd8 */
            ii(0x100d_6e9f, 5); jmpd(0x100d_6f1c, 0x78); goto l_0x100d_6f1c; /* jmp 0x100d6f1c */
        l_0x100d_6ea4:
            ii(0x100d_6ea4, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6ea7, 7); mov(memd_a32[ds, eax + 0x27], 0x101b_5f88); /* mov dword [eax+0x27], 0x101b5f88 */
            ii(0x100d_6eae, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6eb1, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_6eb4, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_6eb7, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_6ebb, 2); if(jzd(0x100d_6ed1, 0x14)) goto l_0x100d_6ed1; /* jz 0x100d6ed1 */
            ii(0x100d_6ebd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_6ebf, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_6ec2, 5); calld(Definitions.my_dtor_d3, 0xe6c);   /* call 0x100d7d33 */
            ii(0x100d_6ec7, 5); calld(Definitions.sys_delete, 0x8_f098); /* call 0x10165f64 */
            ii(0x100d_6ecc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_6ecf, 2); jmpd(0x100d_6ed8, 0x7); goto l_0x100d_6ed8; /* jmp 0x100d6ed8 */
        l_0x100d_6ed1:
            ii(0x100d_6ed1, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_6ed8:
            ii(0x100d_6ed8, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6edb, 4); cmp(memd_a32[ds, eax + 0xa], 0);        /* cmp dword [eax+0xa], 0x0 */
            ii(0x100d_6edf, 2); if(jzd(0x100d_6f0b, 0x2a)) goto l_0x100d_6f0b; /* jz 0x100d6f0b */
            ii(0x100d_6ee1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6ee4, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_6ee7, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_6eea, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x100d_6eee, 2); if(jzd(0x100d_6f04, 0x14)) goto l_0x100d_6f04; /* jz 0x100d6f04 */
            ii(0x100d_6ef0, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_6ef2, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_6ef5, 5); calld(Definitions.my_dtor_d3, 0xe39);   /* call 0x100d7d33 */
            ii(0x100d_6efa, 5); calld(Definitions.sys_delete, 0x8_f065); /* call 0x10165f64 */
            ii(0x100d_6eff, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_6f02, 2); jmpd(0x100d_6f0b, 0x7); goto l_0x100d_6f0b; /* jmp 0x100d6f0b */
        l_0x100d_6f04:
            ii(0x100d_6f04, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
        l_0x100d_6f0b:
            ii(0x100d_6f0b, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_6f12, 2); if(jzd(0x100d_6f1c, 0x8)) goto l_0x100d_6f1c; /* jz 0x100d6f1c */
            ii(0x100d_6f14, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6f17, 5); calld(Definitions.sys_delete, 0x8_f048); /* call 0x10165f64 */
        l_0x100d_6f1c:
            ii(0x100d_6f1c, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_6f1f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_6f22, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_6f25, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_6f27, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_6f28, 1); popd(edi);                              /* pop edi */
            ii(0x100d_6f29, 1); popd(esi);                              /* pop esi */
            ii(0x100d_6f2a, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_6f2b, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_6f2c, 1); retd(); return;                         /* ret */
        }
    }
}
