using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0a3fd3ad-2936-49ea-8cce-8a78c8efe9fb")]
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
            ii(0x100d_fe83, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe87, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100d_fe89, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fe8d, 5); calld(0x1013_3743, 0x5_38b1);           /* call 0x10133743 */
            ii(0x100d_fe92, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_fe95, 5); if(jmpd_func(0x100d_ff75, 0xdb)) return; /* jmp 0x100dff75 */
            ii(0x100d_fe9a, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fe9e, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100d_fea3, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fea7, 5); calld(0x1013_3743, 0x5_3897);           /* call 0x10133743 */
            ii(0x100d_feac, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_feaf, 5); if(jmpd_func(0x100d_ff75, 0xc1)) return; /* jmp 0x100dff75 */
            ii(0x100d_feb4, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_feb8, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x100d_febd, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fec1, 5); calld(0x1013_3743, 0x5_387d);           /* call 0x10133743 */
            ii(0x100d_fec6, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_fec9, 5); if(jmpd_func(0x100d_ff75, 0xa7)) return; /* jmp 0x100dff75 */
            ii(0x100d_fece, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_fed2, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x100d_fed7, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fedb, 5); calld(0x1013_3743, 0x5_3863);           /* call 0x10133743 */
            ii(0x100d_fee0, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_fee3, 5); if(jmpd_func(0x100d_ff75, 0x8d)) return; /* jmp 0x100dff75 */
            ii(0x100d_fee8, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_feec, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x100d_fef1, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_fef5, 5); calld(0x1013_3743, 0x5_3849);           /* call 0x10133743 */
            ii(0x100d_fefa, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_fefd, 5); if(jmpd_func(0x100d_ff75, 0x73)) return; /* jmp 0x100dff75 */
            ii(0x100d_ff02, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_ff06, 5); mov(edx, 0x6);                          /* mov edx, 0x6 */
            ii(0x100d_ff0b, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_ff0f, 5); calld(0x1013_3743, 0x5_382f);           /* call 0x10133743 */
            ii(0x100d_ff14, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_ff17, 2); if(jmpd_func(0x100d_ff75, 0x5c)) return; /* jmp 0x100dff75 */
            ii(0x100d_ff19, 4); movsx(ebx, memw_a32[ss, ebp - 0x8]);    /* movsx ebx, word [ebp-0x8] */
            ii(0x100d_ff1d, 5); mov(edx, 0x5);                          /* mov edx, 0x5 */
            ii(0x100d_ff22, 4); movsx(eax, memw_a32[ss, ebp - 0xc]);    /* movsx eax, word [ebp-0xc] */
            ii(0x100d_ff26, 5); calld(0x1013_3743, 0x5_3818);           /* call 0x10133743 */
            ii(0x100d_ff2b, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        }
    }
}
