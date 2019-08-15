using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0af99be6-a91a-4efb-b0fe-48590aa08b31")]
        public void Method_100b_43b0()
        {
            ii(0x100b_43b0, 5); pushd(0x34);                            /* push 0x34 */
            ii(0x100b_43b5, 5); calld(Definitions.sys_check_available_stack_size, 0xb_1998); /* call 0x10165d52 */
            ii(0x100b_43ba, 1); pushd(esi);                             /* push esi */
            ii(0x100b_43bb, 1); pushd(edi);                             /* push edi */
            ii(0x100b_43bc, 1); pushd(ebp);                             /* push ebp */
            ii(0x100b_43bd, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100b_43bf, 6); sub(esp, 0x24);                         /* sub esp, 0x24 */
            ii(0x100b_43c5, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_43c8, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100b_43cb, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100b_43ce, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100b_43d1, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_43d4, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100b_43d7, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_43da, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x100b_43dd, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100b_43e0, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x100b_43e3, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100b_43e6, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100b_43e9, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100b_43ec, 5); calld(0x1008_ad90, -0x2_9661);          /* call 0x1008ad90 */
            ii(0x100b_43f1, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x100b_43f4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_43f7, 5); calld(0x100a_26d1, -0x1_1d2b);          /* call 0x100a26d1 */
            ii(0x100b_43fc, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_43ff, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_4402, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100b_4405, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_4408, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_440b, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_dd20); /* call 0x100766f0 */
            ii(0x100b_4410, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x100b_4413, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_4416, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_4419, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100b_441c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_441f, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4422, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x3_dd37); /* call 0x100766f0 */
            ii(0x100b_4427, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x100b_442a, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100b_442d, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x100b_4430, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100b_4433, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_4436, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_5264); /* mov dword [eax+0x2], 0x101b5264 */
            ii(0x100b_443d, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100b_4440, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_4443, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x100b_4446, 5); calld(0x1007_6630, -0x3_de1b);          /* call 0x10076630 */
            ii(0x100b_444b, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x100b_444e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_4451, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x100b_4454, 5); calld(0x1007_6630, -0x3_de29);          /* call 0x10076630 */
            ii(0x100b_4459, 3); mov(eax, memd_a32[ss, ebp + 0x10]);     /* mov eax, [ebp+0x10] */
            ii(0x100b_445c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100b_445f, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x100b_4462, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100b_4465, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100b_4468, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100b_446b, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100b_446d, 1); popd(ebp);                              /* pop ebp */
            ii(0x100b_446e, 1); popd(edi);                              /* pop edi */
            ii(0x100b_446f, 1); popd(esi);                              /* pop esi */
            ii(0x100b_4470, 3); retd(0x4); return;                      /* ret 0x4 */
        }
    }
}
