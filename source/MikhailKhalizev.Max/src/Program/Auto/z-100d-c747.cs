using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("abbe1bc5-7030-4cc0-9282-66334ea473e7")]
        public void Method_100d_c747()
        {
            ii(0x100d_c747, 5); pushd(0x2c);                            /* push 0x2c */
            ii(0x100d_c74c, 5); calld(Definitions.sys_check_available_stack_size, 0x8_9601); /* call 0x10165d52 */
            ii(0x100d_c751, 1); pushd(ebx);                             /* push ebx */
            ii(0x100d_c752, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_c753, 1); pushd(esi);                             /* push esi */
            ii(0x100d_c754, 1); pushd(edi);                             /* push edi */
            ii(0x100d_c755, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_c756, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_c758, 6); sub(esp, 0x14);                         /* sub esp, 0x14 */
            ii(0x100d_c75e, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_c761, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100d_c764, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100d_c76b, 2); if(jzd(0x100d_c781, 0x14)) goto l_0x100d_c781; /* jz 0x100dc781 */
            ii(0x100d_c76d, 5); mov(edx, 0x101b_5e50);                  /* mov edx, 0x101b5e50 */
            ii(0x100d_c772, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c775, 5); calld(Definitions.sys_call_dtor_arr, 0x8_983e); /* call 0x10165fb8 */
            ii(0x100d_c77a, 5); calld(Definitions.sys_delete_arr, 0x8_9859); /* call 0x10165fd8 */
            ii(0x100d_c77f, 2); jmpd(0x100d_c7d6, 0x55); goto l_0x100d_c7d6; /* jmp 0x100dc7d6 */
        l_0x100d_c781:
            ii(0x100d_c781, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c784, 7); mov(memd_a32[ds, eax + 0x40], 0x101b_5f04); /* mov dword [eax+0x40], 0x101b5f04 */
            ii(0x100d_c78b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c78e, 3); mov(eax, memd_a32[ds, eax + 0x44]);     /* mov eax, [eax+0x44] */
            ii(0x100d_c791, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_c794, 4); cmp(memd_a32[ss, ebp - 0x14], 0);       /* cmp dword [ebp-0x14], 0x0 */
            ii(0x100d_c798, 2); if(jzd(0x100d_c7ae, 0x14)) goto l_0x100d_c7ae; /* jz 0x100dc7ae */
            ii(0x100d_c79a, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_c79c, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_c79f, 5); calld(Definitions.my_dtor_d3, -0x4a71); /* call 0x100d7d33 */
            ii(0x100d_c7a4, 5); calld(Definitions.sys_delete, 0x8_97bb); /* call 0x10165f64 */
            ii(0x100d_c7a9, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_c7ac, 2); jmpd(0x100d_c7b5, 0x7); goto l_0x100d_c7b5; /* jmp 0x100dc7b5 */
        l_0x100d_c7ae:
            ii(0x100d_c7ae, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x100d_c7b5:
            ii(0x100d_c7b5, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_c7ba, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c7bd, 5); calld(0x100d_00b2, -0xc710);            /* call 0x100d00b2 */
            ii(0x100d_c7c2, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100d_c7c5, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100d_c7cc, 2); if(jzd(0x100d_c7d6, 0x8)) goto l_0x100d_c7d6; /* jz 0x100dc7d6 */
            ii(0x100d_c7ce, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c7d1, 5); calld(Definitions.sys_delete, 0x8_978e); /* call 0x10165f64 */
        l_0x100d_c7d6:
            ii(0x100d_c7d6, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_c7d9, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_c7dc, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100d_c7df, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_c7e1, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_c7e2, 1); popd(edi);                              /* pop edi */
            ii(0x100d_c7e3, 1); popd(esi);                              /* pop esi */
            ii(0x100d_c7e4, 1); popd(ecx);                              /* pop ecx */
            ii(0x100d_c7e5, 1); popd(ebx);                              /* pop ebx */
            ii(0x100d_c7e6, 1); retd(); return;                         /* ret */
        }
    }
}
