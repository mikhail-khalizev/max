using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1010_883e-c79df450")]
        public void my_main()
        {
            ii(0x1010_883e, 5); pushd(0x20);                            /* push 0x20 */
            ii(0x1010_8843, 5); calld(Definitions.sys_check_available_stack_size, 0x5_d50a); /* call 0x10165d52 */
            ii(0x1010_8848, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_8849, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_884a, 1); pushd(esi);                             /* push esi */
            ii(0x1010_884b, 1); pushd(edi);                             /* push edi */
            ii(0x1010_884c, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_884d, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_884f, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_8855, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1010_8858, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1010_885b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1010_885e, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1010_8862, 5); calld(0x1010_83bb, -0x4ac);             /* call 0x101083bb */
            ii(0x1010_8867, 5); calld(0x1010_6a9c, -0x1dd0);            /* call 0x10106a9c */
            ii(0x1010_886c, 5); calld(Definitions.my_play_video_company, 0xcf8e); /* call 0x101157ff */
            ii(0x1010_8871, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1010_8873, 2); if(jnzd(0x1010_8884, 0xf)) goto l_0x1010_8884; /* jnz 0x10108884 */
            ii(0x1010_8875, 5); mov(edx, 0xbb8);                        /* mov edx, 0xbb8 */
            ii(0x1010_887a, 5); mov(eax, 0x6e7);                        /* mov eax, 0x6e7 */
            ii(0x1010_887f, 5); calld(0x1010_8794, -0xf0);              /* call 0x10108794 */
        l_0x1010_8884:
            ii(0x1010_8884, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x1010_8886, 5); mov(edx, 0x6a5);                        /* mov edx, 0x6a5 */
            ii(0x1010_888b, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1010_8890, 5); calld(0x1013_cf8e, 0x3_46f9);           /* call 0x1013cf8e */
            ii(0x1010_8895, 5); mov(edx, 0xbb8);                        /* mov edx, 0xbb8 */
            ii(0x1010_889a, 5); mov(eax, 0x6e8);                        /* mov eax, 0x6e8 */
            ii(0x1010_889f, 5); calld(0x1010_8794, -0x110);             /* call 0x10108794 */
            ii(0x1010_88a4, 5); calld(0x1011_1e00, 0x9557);             /* call 0x10111e00 */
            ii(0x1010_88a9, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_88ab, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_88ac, 1); popd(edi);                              /* pop edi */
            ii(0x1010_88ad, 1); popd(esi);                              /* pop esi */
            ii(0x1010_88ae, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_88af, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_88b0, 1); retd();                                 /* ret */
        }
    }
}
