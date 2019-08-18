using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100b_092c-5e3bf253")]
        public void Method_100b_092c()
        {
            ii(0x100b_092c, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x100b_0931, 5); calld(Definitions.sys_check_available_stack_size, 0xb_541c); /* call 0x10165d52 */
            ii(0x100b_0936, 1); pushd(ebx);                             /* push ebx */
            ii(0x100b_0937, 1); pushd(ecx);                             /* push ecx */
            ii(0x100b_0938, 1); pushd(esi);                             /* push esi */
            ii(0x100b_0939, 1); pushd(edi);                             /* push edi */
            ii(0x100b_093a, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_093b, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_093d, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x100b_0943, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0946, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x100b_0949, 7); test(memd_a32[ss, ebp - 0x4], 0x4);     /* test dword [ebp-0x4], 0x4 */
            ii(0x100b_0950, 2); if(jzd(0x100b_0966, 0x14)) goto l_0x100b_0966; /* jz 0x100b0966 */
            ii(0x100b_0952, 5); mov(edx, 0x101b_515c);                  /* mov edx, 0x101b515c */
            ii(0x100b_0957, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_095a, 5); calld(Definitions.sys_call_dtor_arr, 0xb_5659); /* call 0x10165fb8 */
            ii(0x100b_095f, 5); calld(Definitions.sys_delete_arr, 0xb_5674); /* call 0x10165fd8 */
            ii(0x100b_0964, 2); jmpd(0x100b_09dd, 0x77); goto l_0x100b_09dd; /* jmp 0x100b09dd */
        l_0x100b_0966:
            ii(0x100b_0966, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0969, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_53b4); /* mov dword [eax+0x2], 0x101b53b4 */
            ii(0x100b_0970, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0972, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0975, 3); add(eax, 0x27);                         /* add eax, 0x27 */
            ii(0x100b_0978, 5); calld(0x1008_8cbc, -0x2_7cc1);          /* call 0x10088cbc */
            ii(0x100b_097d, 3); sub(eax, 0x27);                         /* sub eax, 0x27 */
            ii(0x100b_0980, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0983, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0985, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_0988, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x100b_098b, 5); calld(0x1008_8d4c, -0x2_7c44);          /* call 0x10088d4c */
            ii(0x100b_0990, 3); sub(eax, 0x23);                         /* sub eax, 0x23 */
            ii(0x100b_0993, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_0996, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_0998, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_099b, 3); add(eax, 0x19);                         /* add eax, 0x19 */
            ii(0x100b_099e, 5); calld(0x100b_7610, 0x6c6d);             /* call 0x100b7610 */
            ii(0x100b_09a3, 3); sub(eax, 0x19);                         /* sub eax, 0x19 */
            ii(0x100b_09a6, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_09a9, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100b_09ab, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_09ae, 3); add(eax, 0x15);                         /* add eax, 0x15 */
            ii(0x100b_09b1, 5); calld(0x1007_5f2c, -0x3_aa8a);          /* call 0x10075f2c */
            ii(0x100b_09b6, 3); sub(eax, 0x15);                         /* sub eax, 0x15 */
            ii(0x100b_09b9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_09bc, 5); mov(edx, 0x1);                          /* mov edx, 0x1 */
            ii(0x100b_09c1, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_09c4, 5); calld(0x100a_284c, -0xe17d);            /* call 0x100a284c */
            ii(0x100b_09c9, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100b_09cc, 7); test(memd_a32[ss, ebp - 0x4], 0x2);     /* test dword [ebp-0x4], 0x2 */
            ii(0x100b_09d3, 2); if(jzd(0x100b_09dd, 0x8)) goto l_0x100b_09dd; /* jz 0x100b09dd */
            ii(0x100b_09d5, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_09d8, 5); calld(Definitions.sys_delete, 0xb_5587); /* call 0x10165f64 */
        l_0x100b_09dd:
            ii(0x100b_09dd, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100b_09e0, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100b_09e3, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100b_09e6, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_09e8, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_09e9, 1); popd(edi);                              /* pop edi */
            ii(0x100b_09ea, 1); popd(esi);                              /* pop esi */
            ii(0x100b_09eb, 1); popd(ecx);                              /* pop ecx */
            ii(0x100b_09ec, 1); popd(ebx);                              /* pop ebx */
            ii(0x100b_09ed, 1); retd(); return;                         /* ret */
        }
    }
}
