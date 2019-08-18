using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("2c54fcb1-cec2-402e-adac-946c5d71534f")]
        public void Method_1007_ade2()
        {
            ii(0x1007_ade2, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1007_ade7, 5); calld(Definitions.sys_check_available_stack_size, 0xe_af66); /* call 0x10165d52 */
            ii(0x1007_adec, 1); pushd(ebx);                             /* push ebx */
            ii(0x1007_aded, 1); pushd(ecx);                             /* push ecx */
            ii(0x1007_adee, 1); pushd(edx);                             /* push edx */
            ii(0x1007_adef, 1); pushd(esi);                             /* push esi */
            ii(0x1007_adf0, 1); pushd(edi);                             /* push edi */
            ii(0x1007_adf1, 1); pushd(ebp);                             /* push ebp */
            ii(0x1007_adf2, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1007_adf4, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1007_adfa, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1007_adfd, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1007_adff, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ae02, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_ae05, 5); calld(0x1013_ad11, 0xb_ff07);           /* call 0x1013ad11 */
            ii(0x1007_ae0a, 2); test(al, al);                           /* test al, al */
            ii(0x1007_ae0c, 2); if(jzd(0x1007_ae14, 0x6)) goto l_0x1007_ae14; /* jz 0x1007ae14 */
            ii(0x1007_ae0e, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1007_ae12, 2); jmpd(0x1007_ae27, 0x13); goto l_0x1007_ae27; /* jmp 0x1007ae27 */
        l_0x1007_ae14:
            ii(0x1007_ae14, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1007_ae17, 3); add(eax, 0xf);                          /* add eax, 0xf */
            ii(0x1007_ae1a, 5); calld(0x1008_afb4, 0x1_0195);           /* call 0x1008afb4 */
            ii(0x1007_ae1f, 5); calld(0x1008_9928, 0xeb04);             /* call 0x10089928 */
            ii(0x1007_ae24, 3); mov(memb_a32[ss, ebp - 0x8], al);       /* mov [ebp-0x8], al */
        l_0x1007_ae27:
            ii(0x1007_ae27, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1007_ae2a, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1007_ae2c, 1); popd(ebp);                              /* pop ebp */
            ii(0x1007_ae2d, 1); popd(edi);                              /* pop edi */
            ii(0x1007_ae2e, 1); popd(esi);                              /* pop esi */
            ii(0x1007_ae2f, 1); popd(edx);                              /* pop edx */
            ii(0x1007_ae30, 1); popd(ecx);                              /* pop ecx */
            ii(0x1007_ae31, 1); popd(ebx);                              /* pop ebx */
            ii(0x1007_ae32, 1); retd(); return;                         /* ret */
        }
    }
}
