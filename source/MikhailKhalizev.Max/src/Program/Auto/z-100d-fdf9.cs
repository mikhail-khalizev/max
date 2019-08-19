using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100d_fdf9-6b5aea0a")]
        public void Method_100d_fdf9()
        {
            ii(0x100d_fdf9, 5); pushd(0x4c);                            /* push 0x4c */
            ii(0x100d_fdfe, 5); calld(Definitions.sys_check_available_stack_size, 0x8_5f4f); /* call 0x10165d52 */
            ii(0x100d_fe03, 1); pushd(ecx);                             /* push ecx */
            ii(0x100d_fe04, 1); pushd(esi);                             /* push esi */
            ii(0x100d_fe05, 1); pushd(edi);                             /* push edi */
            ii(0x100d_fe06, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_fe07, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_fe09, 6); sub(esp, 0x38);                         /* sub esp, 0x38 */
            ii(0x100d_fe0f, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100d_fe12, 3); mov(memd_a32[ss, ebp - 0x8], edx);      /* mov [ebp-0x8], edx */
            ii(0x100d_fe15, 3); mov(memb_a32[ss, ebp - 0x4], bl);       /* mov [ebp-0x4], bl */
            ii(0x100d_fe18, 4); movsx(eax, memw_a32[ss, ebp - 0x8]);    /* movsx eax, word [ebp-0x8] */
            ii(0x100d_fe1c, 4); movsx(edx, memw_a32[ss, ebp - 0xc]);    /* movsx edx, word [ebp-0xc] */
            ii(0x100d_fe20, 6); imul(edx, edx, 0x247);                  /* imul edx, edx, 0x247 */
            ii(0x100d_fe26, 6); mov(ebx, memd_a32[ds, edx + 0x101c_a562]); /* mov ebx, [edx+0x101ca562] */
            ii(0x100d_fe2c, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe2e, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fe30, 5); calld(0x100c_b6b0, -0x1_4785);          /* call 0x100cb6b0 */
            ii(0x100d_fe35, 3); lea(ebx, ebp - 0x14);                   /* lea ebx, [ebp-0x14] */
            ii(0x100d_fe38, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe3a, 2); mov(eax, ebx);                          /* mov eax, ebx */
            ii(0x100d_fe3c, 5); calld(0x1007_6800, -0x6_9641);          /* call 0x10076800 */
            ii(0x100d_fe41, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe45, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe49, 6); imul(eax, eax, 0x247);                  /* imul eax, eax, 0x247 */
            ii(0x100d_fe4f, 6); mov(eax, memd_a32[ds, eax + 0x101c_a562]); /* mov eax, [eax+0x101ca562] */
            ii(0x100d_fe55, 5); calld(0x1008_b104, -0x5_4d56);          /* call 0x1008b104 */
            ii(0x100d_fe5a, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100d_fe5c, 3); lea(eax, ebp - 0x18);                   /* lea eax, [ebp-0x18] */
            ii(0x100d_fe5f, 5); calld(0x1007_6800, -0x6_9664);          /* call 0x10076800 */
            ii(0x100d_fe64, 4); movsx(ebx, memb_a32[ss, ebp - 0x4]);    /* movsx ebx, byte [ebp-0x4] */
            ii(0x100d_fe68, 4); movsx(edx, memw_a32[ss, ebp - 0x8]);    /* movsx edx, word [ebp-0x8] */
            ii(0x100d_fe6c, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe70, 5); calld(0x100d_fd69, -0x10c);             /* call 0x100dfd69 */
            ii(0x100d_fe75, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_fe78, 3); mov(al, memb_a32[ss, ebp - 0x4]);       /* mov al, [ebp-0x4] */
            ii(0x100d_fe7b, 3); mov(memb_a32[ss, ebp - 0x10], al);      /* mov [ebp-0x10], al */
            ii(0x100d_fe7e, 5); if(jmpd_func(0x100d_ff58, 0xd5)) return; /* jmp 0x100dff58 */
        }
    }
}
