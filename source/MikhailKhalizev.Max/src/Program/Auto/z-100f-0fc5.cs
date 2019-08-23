using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_0fc5-26b38c77")]
        public void Method_100f_0fc5()
        {
            ii(0x100f_0fc5, 5); pushd(0x28);                            /* push 0x28 */
            ii(0x100f_0fca, 5); calld(Definitions.sys_check_available_stack_size, 0x7_4d83); /* call 0x10165d52 */
            ii(0x100f_0fcf, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_0fd0, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_0fd1, 1); pushd(edx);                             /* push edx */
            ii(0x100f_0fd2, 1); pushd(esi);                             /* push esi */
            ii(0x100f_0fd3, 1); pushd(edi);                             /* push edi */
            ii(0x100f_0fd4, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_0fd5, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_0fd7, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100f_0fdd, 7); mov(memd_a32[ss, ebp - 0x4], 0);        /* mov dword [ebp-0x4], 0x0 */
            ii(0x100f_0fe4, 2); jmpd(0x100f_0fec, 0x6); goto l_0x100f_0fec; /* jmp 0x100f0fec */
        l_0x100f_0fe6:
            ii(0x100f_0fe6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_0fe9, 3); inc(memd_a32[ss, ebp - 0x4]);           /* inc dword [ebp-0x4] */
        l_0x100f_0fec:
            ii(0x100f_0fec, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_0ff0, 3); cmp(eax, 0x18);                         /* cmp eax, 0x18 */
            ii(0x100f_0ff3, 2); if(jaed(0x100f_1049, 0x54)) goto l_0x100f_1049; /* jae 0x100f1049 */
            ii(0x100f_0ff5, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_0ff9, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_0ffc, 7); cmp(memd_a32[ds, eax + 0x101b_8753], 0); /* cmp dword [eax+0x101b8753], 0x0 */
            ii(0x100f_1003, 2); if(jzd(0x100f_1047, 0x42)) goto l_0x100f_1047; /* jz 0x100f1047 */
            ii(0x100f_1005, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_1009, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_100c, 6); mov(eax, memd_a32[ds, eax + 0x101b_8753]); /* mov eax, [eax+0x101b8753] */
            ii(0x100f_1012, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_1015, 4); cmp(memd_a32[ss, ebp - 0x8], 0);        /* cmp dword [ebp-0x8], 0x0 */
            ii(0x100f_1019, 2); if(jzd(0x100f_102f, 0x14)) goto l_0x100f_102f; /* jz 0x100f102f */
            ii(0x100f_101b, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_101d, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_1020, 5); calld(Definitions.my_dtor_d2, -0x2_2aed); /* call 0x100ce538 */
            ii(0x100f_1025, 5); calld(Definitions.sys_delete, 0x7_4f3a); /* call 0x10165f64 */
            ii(0x100f_102a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_102d, 2); jmpd(0x100f_1036, 0x7); goto l_0x100f_1036; /* jmp 0x100f1036 */
        l_0x100f_102f:
            ii(0x100f_102f, 7); mov(memd_a32[ss, ebp - 0xc], 0);        /* mov dword [ebp-0xc], 0x0 */
        l_0x100f_1036:
            ii(0x100f_1036, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100f_103a, 3); imul(eax, eax, 0xe);                    /* imul eax, eax, 0xe */
            ii(0x100f_103d, 10); mov(memd_a32[ds, eax + 0x101b_8753], 0); /* mov dword [eax+0x101b8753], 0x0 */
        l_0x100f_1047:
            ii(0x100f_1047, 2); jmpd(0x100f_0fe6, -0x63); goto l_0x100f_0fe6; /* jmp 0x100f0fe6 */
        l_0x100f_1049:
            ii(0x100f_1049, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_104b, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_104c, 1); popd(edi);                              /* pop edi */
            ii(0x100f_104d, 1); popd(esi);                              /* pop esi */
            ii(0x100f_104e, 1); popd(edx);                              /* pop edx */
            ii(0x100f_104f, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_1050, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_1051, 1); retd();                                 /* ret */
        }
    }
}
