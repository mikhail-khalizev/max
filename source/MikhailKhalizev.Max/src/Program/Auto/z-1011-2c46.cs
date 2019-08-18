using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("3d1919e3-b8c5-466e-9405-0e4b01887e05")]
        public void Method_1011_2c46()
        {
            ii(0x1011_2c46, 5); pushd(0x44);                            /* push 0x44 */
            ii(0x1011_2c4b, 5); calld(Definitions.sys_check_available_stack_size, 0x5_3102); /* call 0x10165d52 */
            ii(0x1011_2c50, 1); pushd(esi);                             /* push esi */
            ii(0x1011_2c51, 1); pushd(edi);                             /* push edi */
            ii(0x1011_2c52, 1); pushd(ebp);                             /* push ebp */
            ii(0x1011_2c53, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1011_2c55, 6); sub(esp, 0x1c);                         /* sub esp, 0x1c */
            ii(0x1011_2c5b, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1011_2c5e, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x1011_2c61, 3); mov(memd_a32[ss, ebp - 0xc], ebx);      /* mov [ebp-0xc], ebx */
            ii(0x1011_2c64, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1011_2c67, 6); mov(ax, memw_a32[ds, 0x101b_9db4]);     /* mov ax, [0x101b9db4] */
            ii(0x1011_2c6d, 5); add(eax, 0x5);                          /* add eax, 0x5 */
            ii(0x1011_2c72, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1011_2c75, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1011_2c78, 4); imul(eax, memd_a32[ss, ebp - 0x4]);     /* imul eax, [ebp-0x4] */
            ii(0x1011_2c7c, 7); mov(dx, memw_a32[ds, 0x101b_9db8]);     /* mov dx, [0x101b9db8] */
            ii(0x1011_2c83, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x1011_2c85, 3); mov(memd_a32[ss, ebp - 0x18], edx);     /* mov [ebp-0x18], edx */
            ii(0x1011_2c88, 6); mov(ax, memw_a32[ds, 0x101b_9dbc]);     /* mov ax, [0x101b9dbc] */
            ii(0x1011_2c8e, 3); sub(eax, memd_a32[ss, ebp - 0x14]);     /* sub eax, [ebp-0x14] */
            ii(0x1011_2c91, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1011_2c94, 5); calld(0x100d_531c, -0x3_d97d);          /* call 0x100d531c */
            ii(0x1011_2c99, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1011_2c9e, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2c9f, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x1011_2ca1, 3); mov(al, memb_a32[ss, ebp + 0x10]);      /* mov al, [ebp+0x10] */
            ii(0x1011_2ca4, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2ca5, 2); pushd(0x2);                             /* push 0x2 */
            ii(0x1011_2ca7, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x1011_2cab, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2cac, 4); movsx(eax, memw_a32[ss, ebp - 0x1c]);   /* movsx eax, word [ebp-0x1c] */
            ii(0x1011_2cb0, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2cb1, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1011_2cb5, 1); pushd(eax);                             /* push eax */
            ii(0x1011_2cb6, 4); movsx(ecx, memw_a32[ss, ebp - 0x14]);   /* movsx ecx, word [ebp-0x14] */
            ii(0x1011_2cba, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1011_2cbd, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_2cc0, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2cc2, 3); mov(edx, memd_a32[ds, eax + 0xe]);      /* mov edx, [eax+0xe] */
            ii(0x1011_2cc5, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x1011_2cc8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1011_2ccb, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1011_2ccd, 3); mov(eax, memd_a32[ds, eax + 0x16]);     /* mov eax, [eax+0x16] */
            ii(0x1011_2cd0, 5); calld(0x100e_9ae5, -0x2_91f0);          /* call 0x100e9ae5 */
            ii(0x1011_2cd5, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1011_2cd7, 1); popd(ebp);                              /* pop ebp */
            ii(0x1011_2cd8, 1); popd(edi);                              /* pop edi */
            ii(0x1011_2cd9, 1); popd(esi);                              /* pop esi */
            ii(0x1011_2cda, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
