using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("716d4923-290a-43de-a254-8308bc75fc63")]
        public void Method_1008_0912()
        {
            ii(0x1008_0912, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1008_0917, 5); calld(Definitions.sys_check_available_stack_size, 0xe_5436); /* call 0x10165d52 */
            ii(0x1008_091c, 1); pushd(ebx);                             /* push ebx */
            ii(0x1008_091d, 1); pushd(ecx);                             /* push ecx */
            ii(0x1008_091e, 1); pushd(esi);                             /* push esi */
            ii(0x1008_091f, 1); pushd(edi);                             /* push edi */
            ii(0x1008_0920, 1); pushd(ebp);                             /* push ebp */
            ii(0x1008_0921, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1008_0923, 6); sub(esp, 0x18);                         /* sub esp, 0x18 */
            ii(0x1008_0929, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1008_092c, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1008_092f, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_0932, 3); mov(eax, memd_a32[ds, eax + 0x7]);      /* mov eax, [eax+0x7] */
            ii(0x1008_0935, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1008_0938, 6); imul(edx, eax, 0xc5);                   /* imul edx, eax, 0xc5 */
            ii(0x1008_093e, 5); mov(eax, 0x101c_31c4);                  /* mov eax, 0x101c31c4 */
            ii(0x1008_0943, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_0945, 5); calld(0x1008_a0c8, 0x977e);             /* call 0x1008a0c8 */
            ii(0x1008_094a, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1008_094d, 4); cmp(memd_a32[ss, ebp - 0xc], 0);        /* cmp dword [ebp-0xc], 0x0 */
            ii(0x1008_0951, 6); if(jzd(0x1008_09d9, 0x82)) goto l_0x1008_09d9; /* jz 0x100809d9 */
            ii(0x1008_0957, 7); mov(memd_a32[ss, ebp - 0x18], 0);       /* mov dword [ebp-0x18], 0x0 */
            ii(0x1008_095e, 2); jmpd(0x1008_0966, 0x6); goto l_0x1008_0966; /* jmp 0x10080966 */
        l_0x1008_0960:
            ii(0x1008_0960, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_0963, 3); inc(memd_a32[ss, ebp - 0x18]);          /* inc dword [ebp-0x18] */
        l_0x1008_0966:
            ii(0x1008_0966, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x1008_0969, 7); cmp(ax, memw_a32[ds, 0x101c_8172]);     /* cmp ax, [0x101c8172] */
            ii(0x1008_0970, 2); if(jged(0x1008_09d9, 0x67)) goto l_0x1008_09d9; /* jge 0x100809d9 */
            ii(0x1008_0972, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x1008_0979, 2); jmpd(0x1008_0981, 0x6); goto l_0x1008_0981; /* jmp 0x10080981 */
        l_0x1008_097b:
            ii(0x1008_097b, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_097e, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x1008_0981:
            ii(0x1008_0981, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1008_0984, 7); cmp(ax, memw_a32[ds, 0x101c_8174]);     /* cmp ax, [0x101c8174] */
            ii(0x1008_098b, 2); if(jged(0x1008_09d7, 0x4a)) goto l_0x1008_09d7; /* jge 0x100809d7 */
            ii(0x1008_098d, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1008_0991, 3); shl(eax, 0x2);                          /* shl eax, 0x2 */
            ii(0x1008_0994, 3); add(eax, memd_a32[ss, ebp - 0xc]);      /* add eax, [ebp-0xc] */
            ii(0x1008_0997, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1008_099b, 2); mov(eax, memd_a32[ds, eax]);            /* mov eax, [eax] */
            ii(0x1008_099d, 2); add(eax, edx);                          /* add eax, edx */
            ii(0x1008_099f, 3); test(memb_a32[ds, eax], 0x2);           /* test byte [eax], 0x2 */
            ii(0x1008_09a2, 2); if(jzd(0x1008_09d5, 0x31)) goto l_0x1008_09d5; /* jz 0x100809d5 */
            ii(0x1008_09a4, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x1008_09a8, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_09ab, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x1008_09ad, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x1008_09b1, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_09b4, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
            ii(0x1008_09b7, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x1008_09bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_09be, 1); inc(edx);                               /* inc edx */
            ii(0x1008_09bf, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x1008_09c2, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x1008_09c6, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_09c9, 1); inc(edx);                               /* inc edx */
            ii(0x1008_09ca, 3); mov(memd_a32[ds, eax + 0xc], edx);      /* mov [eax+0xc], edx */
            ii(0x1008_09cd, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1008_09d0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1008_09d3, 2); jmpd(0x1008_09e7, 0x12); goto l_0x1008_09e7; /* jmp 0x100809e7 */
        l_0x1008_09d5:
            ii(0x1008_09d5, 2); jmpd(0x1008_097b, -0x5c); goto l_0x1008_097b; /* jmp 0x1008097b */
        l_0x1008_09d7:
            ii(0x1008_09d7, 2); jmpd(0x1008_0960, -0x79); goto l_0x1008_0960; /* jmp 0x10080960 */
        l_0x1008_09d9:
            ii(0x1008_09d9, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1008_09dc, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1008_09df, 5); calld(0x100a_2ce8, 0x2_2304);           /* call 0x100a2ce8 */
            ii(0x1008_09e4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
        l_0x1008_09e7:
            ii(0x1008_09e7, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1008_09ea, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1008_09ec, 1); popd(ebp);                              /* pop ebp */
            ii(0x1008_09ed, 1); popd(edi);                              /* pop edi */
            ii(0x1008_09ee, 1); popd(esi);                              /* pop esi */
            ii(0x1008_09ef, 1); popd(ecx);                              /* pop ecx */
            ii(0x1008_09f0, 1); popd(ebx);                              /* pop ebx */
            ii(0x1008_09f1, 1); retd(); return;                         /* ret */
        }
    }
}
