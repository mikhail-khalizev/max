using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("671f97ca-599b-465e-8519-babf872a49f0")]
        public void Method_1011_7319()
        {
            ii(0x1011_7319, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x1011_731e, 5); calld(Definitions.sys_check_available_stack_size, 0x4_ea2f); /* call 0x10165d52 */
            ii(0x1011_7323, 1); pushd(ebx);                             /* push ebx */
            ii(0x1011_7324, 1); pushd(ecx);                             /* push ecx */
            ii(0x1011_7325, 1); pushd(esi);                             /* push esi */
            ii(0x1011_7326, 1); pushd(edi);                             /* push edi */
            ii(0x1011_7327, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_7328, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_732a, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_7330, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_7333, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1011_7336, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x1011_733d, 2); if(jzd(0x1011_7356, 0x17)) goto l_0x1011_7356; /* jz 0x10117356 */
            ii(0x1011_733f, 5); mov(edx, 0x101b_66f4);                  /* mov edx, 0x101b66f4 */
            ii(0x1011_7344, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7347, 5); calld(Definitions.sys_call_dtor_arr, 0x4_ec6c); /* call 0x10165fb8 */
            ii(0x1011_734c, 5); calld(Definitions.sys_delete_arr, 0x4_ec87); /* call 0x10165fd8 */
            ii(0x1011_7351, 5); jmpd(0x1011_73da, 0x84); goto l_0x1011_73da; /* jmp 0x101173da */
        l_0x1011_7356:
            ii(0x1011_7356, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7359, 7); mov(memd_a32[ds, eax + 0x13], 0x101b_6734); /* mov dword [eax+0x13], 0x101b6734 */
            ii(0x1011_7360, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_7363, 3); mov(eax, memd_a32[ds, eax + 0x33]);     /* mov eax, [eax+0x33] */
            ii(0x1011_7366, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_7369, 4); cmp(memd_a32[ss, ebp - 0x1c], 0);       /* cmp dword [ebp-0x1c], 0x0 */
            ii(0x1011_736d, 2); if(jzd(0x1011_7383, 0x14)) goto l_0x1011_7383; /* jz 0x10117383 */
            ii(0x1011_736f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_7371, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x1011_7374, 5); calld(Definitions.my_dtor_d2, -0x4_8e41); /* call 0x100ce538 */
            ii(0x1011_7379, 5); calld(Definitions.sys_delete, 0x4_ebe6); /* call 0x10165f64 */
            ii(0x1011_737e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_7381, 2); jmpd(0x1011_738a, 0x7); goto l_0x1011_738a; /* jmp 0x1011738a */
        l_0x1011_7383:
            ii(0x1011_7383, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
        l_0x1011_738a:
            ii(0x1011_738a, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_738d, 3); mov(eax, memd_a32[ds, eax + 0x37]);     /* mov eax, [eax+0x37] */
            ii(0x1011_7390, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1011_7393, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x1011_7397, 2); if(jzd(0x1011_73ad, 0x14)) goto l_0x1011_73ad; /* jz 0x101173ad */
            ii(0x1011_7399, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1011_739b, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1011_739e, 5); calld(Definitions.my_dtor_d2, -0x4_8e6b); /* call 0x100ce538 */
            ii(0x1011_73a3, 5); calld(Definitions.sys_delete, 0x4_ebbc); /* call 0x10165f64 */
            ii(0x1011_73a8, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_73ab, 2); jmpd(0x1011_73b4, 0x7); goto l_0x1011_73b4; /* jmp 0x101173b4 */
        l_0x1011_73ad:
            ii(0x1011_73ad, 7); mov(memd_a32[ss, ebp - 0x10], 0);       /* mov dword [ebp-0x10], 0x0 */
        l_0x1011_73b4:
            ii(0x1011_73b4, 5); calld(0x100e_a903, -0x2_cab6);          /* call 0x100ea903 */
            ii(0x1011_73b9, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x1011_73be, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_73c1, 5); calld(0x100d_6999, -0x4_0a2d);          /* call 0x100d6999 */
            ii(0x1011_73c6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1011_73c9, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x1011_73d0, 2); if(jzd(0x1011_73da, 0x8)) goto l_0x1011_73da; /* jz 0x101173da */
            ii(0x1011_73d2, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_73d5, 5); calld(Definitions.sys_delete, 0x4_eb8a); /* call 0x10165f64 */
        l_0x1011_73da:
            ii(0x1011_73da, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_73dd, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1011_73e0, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1011_73e3, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_73e5, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_73e6, 1); popd(edi);                              /* pop edi */
            ii(0x1011_73e7, 1); popd(esi);                              /* pop esi */
            ii(0x1011_73e8, 1); popd(ecx);                              /* pop ecx */
            ii(0x1011_73e9, 1); popd(ebx);                              /* pop ebx */
            ii(0x1011_73ea, 1); retd(); return;                         /* ret */
        }
    }
}
