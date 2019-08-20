using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x1012_2cbe-ca61d0f1")]
        public void Method_1012_2cbe()
        {
            ii(0x1012_2cbe, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1012_2cc1, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1012_2cc4, 4); cmp(ax, memw_a32[ds, edx + 0x49]);      /* cmp ax, [edx+0x49] */
            ii(0x1012_2cc8, 6); if(jged_func(0x1012_2dfe, 0x130)) return; /* jge 0x10122dfe */
            ii(0x1012_2cce, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2cd2, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2cd5, 6); mov(al, memb_a32[ds, eax + 0x101b_b061]); /* mov al, [eax+0x101bb061] */
            ii(0x1012_2cdb, 3); mov(memb_a32[ss, ebp - 0x44], al);      /* mov [ebp-0x44], al */
            ii(0x1012_2cde, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2ce2, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2ce5, 7); mov(ax, memw_a32[ds, eax + 0x101b_b076]); /* mov ax, [eax+0x101bb076] */
            ii(0x1012_2cec, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x1012_2cef, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x1012_2cf3, 3); imul(eax, eax, 0x1c);                   /* imul eax, eax, 0x1c */
            ii(0x1012_2cf6, 7); mov(ax, memw_a32[ds, eax + 0x101b_b074]); /* mov ax, [eax+0x101bb074] */
            ii(0x1012_2cfd, 4); cmp(ax, memw_a32[ss, ebp - 0x48]);      /* cmp ax, [ebp-0x48] */
            ii(0x1012_2d01, 6); if(jzd_func(0x1012_2df9, 0xf2)) return; /* jz 0x10122df9 */
            ii(0x1012_2d07, 3); mov(al, memb_a32[ss, ebp - 0x44]);      /* mov al, [ebp-0x44] */
            ii(0x1012_2d0a, 3); mov(memb_a32[ss, ebp - 0x4c], al);      /* mov [ebp-0x4c], al */
            ii(0x1012_2d0d, 5); if(jmpd_func(0x1012_2ddc, 0xca)) return; /* jmp 0x10122ddc */
            ii(0x1012_2d12, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x1012_2d16, 4); movsx(ebx, memw_a32[ss, ebp - 0x48]);   /* movsx ebx, word [ebp-0x48] */
            ii(0x1012_2d1a, 5); mov(edx, 0x4);                          /* mov edx, 0x4 */
            ii(0x1012_2d1f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2d22, 5); calld(0x1012_26c4, -0x663);             /* call 0x101226c4 */
            ii(0x1012_2d27, 5); if(jmpd_func(0x1012_2df9, 0xcd)) return; /* jmp 0x10122df9 */
            ii(0x1012_2d2c, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x1012_2d30, 4); movsx(ebx, memw_a32[ss, ebp - 0x48]);   /* movsx ebx, word [ebp-0x48] */
            ii(0x1012_2d34, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1012_2d39, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2d3c, 5); calld(0x1012_26c4, -0x67d);             /* call 0x101226c4 */
            ii(0x1012_2d41, 5); if(jmpd_func(0x1012_2df9, 0xb3)) return; /* jmp 0x10122df9 */
            ii(0x1012_2d46, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x1012_2d4a, 4); movsx(ebx, memw_a32[ss, ebp - 0x48]);   /* movsx ebx, word [ebp-0x48] */
            ii(0x1012_2d4e, 5); mov(edx, 0x3);                          /* mov edx, 0x3 */
            ii(0x1012_2d53, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1012_2d56, 5); calld(0x1012_26c4, -0x697);             /* call 0x101226c4 */
            ii(0x1012_2d5b, 5); if(jmpd_func(0x1012_2df9, 0x99)) return; /* jmp 0x10122df9 */
            ii(0x1012_2d60, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_2d64, 5); mov(eax, 0x39);                         /* mov eax, 0x39 */
            ii(0x1012_2d69, 5); calld(0x100c_aafc, -0x5_8272);          /* call 0x100caafc */
            ii(0x1012_2d6e, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2d70, 3); mov(dl, memb_a32[ss, ebp - 0x48]);      /* mov dl, [ebp-0x48] */
            ii(0x1012_2d73, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2d78, 5); calld(0x1013_d2c4, 0x1_a547);           /* call 0x1013d2c4 */
            ii(0x1012_2d7d, 5); if(jmpd_func(0x1012_2df9, 0x77)) return; /* jmp 0x10122df9 */
            ii(0x1012_2d82, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_2d86, 5); mov(eax, 0x3a);                         /* mov eax, 0x3a */
            ii(0x1012_2d8b, 5); calld(0x100c_aafc, -0x5_8294);          /* call 0x100caafc */
            ii(0x1012_2d90, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2d92, 3); mov(dl, memb_a32[ss, ebp - 0x48]);      /* mov dl, [ebp-0x48] */
            ii(0x1012_2d95, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2d9a, 5); calld(0x1013_d323, 0x1_a584);           /* call 0x1013d323 */
            ii(0x1012_2d9f, 2); if(jmpd_func(0x1012_2df9, 0x58)) return; /* jmp 0x10122df9 */
            ii(0x1012_2da1, 4); movsx(edx, memw_a32[ss, ebp - 0x48]);   /* movsx edx, word [ebp-0x48] */
            ii(0x1012_2da5, 5); mov(eax, 0x3b);                         /* mov eax, 0x3b */
            ii(0x1012_2daa, 5); calld(0x100c_aafc, -0x5_82b3);          /* call 0x100caafc */
            ii(0x1012_2daf, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1012_2db1, 3); mov(dl, memb_a32[ss, ebp - 0x48]);      /* mov dl, [ebp-0x48] */
            ii(0x1012_2db4, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1012_2db9, 5); calld(0x1013_d409, 0x1_a64b);           /* call 0x1013d409 */
            ii(0x1012_2dbe, 2); if(jmpd_func(0x1012_2df9, 0x39)) return; /* jmp 0x10122df9 */
        }
    }
}
