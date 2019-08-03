using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("1d26568d-0524-42f7-b7b4-c1fa688b0e7e")]
        public void Method_1010_c628()
        {
            ii(0x1010_c628, 5); pushd(0x38);                            /* push 0x38 */
            ii(0x1010_c62d, 5); calld(Definitions.sys_check_available_stack_size, 0x59720); /* call 0x10165d52 */
            ii(0x1010_c632, 1); pushd(ebx);                             /* push ebx */
            ii(0x1010_c633, 1); pushd(ecx);                             /* push ecx */
            ii(0x1010_c634, 1); pushd(esi);                             /* push esi */
            ii(0x1010_c635, 1); pushd(edi);                             /* push edi */
            ii(0x1010_c636, 1); pushd(ebp);                             /* push ebp */
            ii(0x1010_c637, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1010_c639, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1010_c63f, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1010_c642, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1010_c645, 5); mov(eax, 0x5);                          /* mov eax, 0x5 */
            ii(0x1010_c64a, 5); calld(/* sys */ 0x1016_a24c, 0x5dbfd);  /* call 0x1016a24c */
            ii(0x1010_c64f, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_c654, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c655, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x1010_c65a, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c65b, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x1010_c65d, 5); mov(eax, 0xf);                          /* mov eax, 0xf */
            ii(0x1010_c662, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c663, 5); mov(eax, 0xac);                         /* mov eax, 0xac */
            ii(0x1010_c668, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c669, 5); mov(eax, 0x91);                         /* mov eax, 0x91 */
            ii(0x1010_c66e, 1); pushd(eax);                             /* push eax */
            ii(0x1010_c66f, 5); mov(ecx, 0xec);                         /* mov ecx, 0xec */
            ii(0x1010_c674, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x1010_c677, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c67a, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1010_c67d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1010_c680, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1010_c683, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1010_c686, 5); calld(0x100e_9ae5, -0x22ba6);           /* call 0x100e9ae5 */
            ii(0x1010_c68b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1010_c68d, 1); popd(ebp);                              /* pop ebp */
            ii(0x1010_c68e, 1); popd(edi);                              /* pop edi */
            ii(0x1010_c68f, 1); popd(esi);                              /* pop esi */
            ii(0x1010_c690, 1); popd(ecx);                              /* pop ecx */
            ii(0x1010_c691, 1); popd(ebx);                              /* pop ebx */
            ii(0x1010_c692, 1); retd(); return;                         /* ret */
        }
    }
}