using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("30249939-5723-4259-a05c-acc2f46ef1f6")]
        public void Method_100c_f363()
        {
            ii(0x100c_f363, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x100c_f368, 5); calld(Definitions.sys_check_available_stack_size, 0x969e5); /* call 0x10165d52 */
            ii(0x100c_f36d, 1); pushd(ebx);                             /* push ebx */
            ii(0x100c_f36e, 1); pushd(ecx);                             /* push ecx */
            ii(0x100c_f36f, 1); pushd(esi);                             /* push esi */
            ii(0x100c_f370, 1); pushd(edi);                             /* push edi */
            ii(0x100c_f371, 1); pushd(ebp);                             /* push ebp */
            ii(0x100c_f372, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100c_f374, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x100c_f37a, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100c_f37d, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100c_f380, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f383, 4); cmp(memd_a32[ds, eax + 0x18], 0);       /* cmp dword [eax+0x18], 0x0 */
            ii(0x100c_f387, 2); if(jzd(0x100c_f3b3, 0x2a)) goto l_0x100c_f3b3; /* jz 0x100cf3b3 */
            ii(0x100c_f389, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f38c, 3); mov(eax, memd_a32[ds, eax + 0x18]);     /* mov eax, [eax+0x18] */
            ii(0x100c_f38f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100c_f392, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x100c_f396, 2); if(jzd(0x100c_f3ac, 0x14)) goto l_0x100c_f3ac; /* jz 0x100cf3ac */
            ii(0x100c_f398, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100c_f39a, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100c_f39d, 5); calld(Definitions.my_dtor_d3, 0x8991);  /* call 0x100d7d33 */
            ii(0x100c_f3a2, 5); calld(Definitions.sys_delete, 0x96bbd); /* call 0x10165f64 */
            ii(0x100c_f3a7, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100c_f3aa, 2); jmpd(0x100c_f3b3, 0x7); goto l_0x100c_f3b3; /* jmp 0x100cf3b3 */
        l_0x100c_f3ac:
            ii(0x100c_f3ac, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100c_f3b3:
            ii(0x100c_f3b3, 5); mov(eax, 0xd);                          /* mov eax, 0xd */
            ii(0x100c_f3b8, 5); calld(Definitions.sys_new, 0x96a43);    /* call 0x10165e00 */
            ii(0x100c_f3bd, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100c_f3c0, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f3c3, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100c_f3c6, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100c_f3ca, 2); if(jzd(0x100c_f3f5, 0x29)) goto l_0x100c_f3f5; /* jz 0x100cf3f5 */
            ii(0x100c_f3cc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f3cf, 3); mov(ecx, memd_a32[ds, eax + 0x4]);      /* mov ecx, [eax+0x4] */
            ii(0x100c_f3d2, 3); sar(ecx, 0x10);                         /* sar ecx, 0x10 */
            ii(0x100c_f3d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100c_f3d8, 3); mov(ebx, memd_a32[ds, eax + 0x2]);      /* mov ebx, [eax+0x2] */
            ii(0x100c_f3db, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100c_f3de, 4); movsx(edx, memw_a32[ss, ebp - 0x4]);    /* movsx edx, word [ebp-0x4] */
            ii(0x100c_f3e2, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100c_f3e5, 5); calld(Definitions.my_ctor_c19, 0x8874); /* call 0x100d7c5e */
            ii(0x100c_f3ea, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100c_f3ed, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100c_f3f0, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100c_f3f3, 2); jmpd(0x100c_f3fb, 0x6); goto l_0x100c_f3fb; /* jmp 0x100cf3fb */
        l_0x100c_f3f5:
            ii(0x100c_f3f5, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100c_f3f8, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100c_f3fb:
            ii(0x100c_f3fb, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100c_f3fe, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100c_f401, 3); mov(memd_a32[ds, edx + 0x18], eax);     /* mov [edx+0x18], eax */
            ii(0x100c_f404, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100c_f406, 1); popd(ebp);                              /* pop ebp */
            ii(0x100c_f407, 1); popd(edi);                              /* pop edi */
            ii(0x100c_f408, 1); popd(esi);                              /* pop esi */
            ii(0x100c_f409, 1); popd(ecx);                              /* pop ecx */
            ii(0x100c_f40a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100c_f40b, 1); retd(); return;                         /* ret */
        }
    }
}