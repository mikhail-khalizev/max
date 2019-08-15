using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc1d8240-7f6f-481d-96dc-7664c13c5c14")]
        public void my_ctor_c9()
        {
            ii(0x1009_d12a, 5); pushd(0x30);                            /* push 0x30 */
            ii(0x1009_d12f, 5); calld(Definitions.sys_check_available_stack_size, 0xc_8c1e); /* call 0x10165d52 */
            ii(0x1009_d134, 1); pushd(esi);                             /* push esi */
            ii(0x1009_d135, 1); pushd(edi);                             /* push edi */
            ii(0x1009_d136, 1); pushd(ebp);                             /* push ebp */
            ii(0x1009_d137, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1009_d139, 6); sub(esp, 0x20);                         /* sub esp, 0x20 */
            ii(0x1009_d13f, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d142, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x1009_d145, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x1009_d148, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x1009_d14b, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_d14e, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x1009_d151, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_d154, 3); mov(edx, memd_a32[ds, eax + 0x2]);      /* mov edx, [eax+0x2] */
            ii(0x1009_d157, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x1009_d15a, 3); calld_abs(memd_a32[ds, edx + 0x14]);    /* call dword [edx+0x14] */
            ii(0x1009_d15d, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x1009_d160, 3); mov(ebx, memd_a32[ss, ebp - 0xc]);      /* mov ebx, [ebp-0xc] */
            ii(0x1009_d163, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_d166, 5); calld(0x1008_ad90, -0x1_23db);          /* call 0x1008ad90 */
            ii(0x1009_d16b, 3); movsx(edx, ax);                         /* movsx edx, ax */
            ii(0x1009_d16e, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d171, 5); calld(0x100a_26d1, 0x555b);             /* call 0x100a26d1 */
            ii(0x1009_d176, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d179, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_d17c, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x1009_d17f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d182, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d185, 5); calld(Definitions.my_ctor_0x101b_38f8, -0x2_6a9a); /* call 0x100766f0 */
            ii(0x1009_d18a, 3); sub(eax, 0x13);                         /* sub eax, 0x13 */
            ii(0x1009_d18d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d190, 3); lea(eax, ebp - 0x10);                   /* lea eax, [ebp-0x10] */
            ii(0x1009_d193, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x1009_d196, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d199, 3); add(eax, 0x17);                         /* add eax, 0x17 */
            ii(0x1009_d19c, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_66b1); /* call 0x10076af0 */
            ii(0x1009_d1a1, 3); sub(eax, 0x17);                         /* sub eax, 0x17 */
            ii(0x1009_d1a4, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d1a7, 5); mov(ebx, 0x101b_4184);                  /* mov ebx, 0x101b4184 */
            ii(0x1009_d1ac, 5); mov(edx, 0x2);                          /* mov edx, 0x2 */
            ii(0x1009_d1b1, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1b4, 3); add(eax, 0x23);                         /* add eax, 0x23 */
            ii(0x1009_d1b7, 5); calld(Definitions.sys_call_ctor_arr_v2, 0xc_8db4); /* call 0x10165f70 */
            ii(0x1009_d1bc, 3); sub(eax, 0x23);                         /* sub eax, 0x23 */
            ii(0x1009_d1bf, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d1c2, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1c5, 3); add(eax, 0x2f);                         /* add eax, 0x2f */
            ii(0x1009_d1c8, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_66dd); /* call 0x10076af0 */
            ii(0x1009_d1cd, 3); sub(eax, 0x2f);                         /* sub eax, 0x2f */
            ii(0x1009_d1d0, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d1d3, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1d6, 3); add(eax, 0x33);                         /* add eax, 0x33 */
            ii(0x1009_d1d9, 5); calld(Definitions.my_ctor_0x101b_4184, -0x2_66ee); /* call 0x10076af0 */
            ii(0x1009_d1de, 3); sub(eax, 0x33);                         /* sub eax, 0x33 */
            ii(0x1009_d1e1, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x1009_d1e4, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1e7, 7); mov(memd_a32[ds, eax + 0x2], 0x101b_4abc); /* mov dword [eax+0x2], 0x101b4abc */
            ii(0x1009_d1ee, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1f1, 4); mov(memb_a32[ds, eax + 0x3e], 0);       /* mov byte [eax+0x3e], 0x0 */
            ii(0x1009_d1f5, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1009_d1f8, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d1fb, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d1fe, 5); calld(0x1007_6630, -0x2_6bd3);          /* call 0x10076630 */
            ii(0x1009_d203, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d206, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d209, 5); calld(0x1007_6574, -0x2_6c9a);          /* call 0x10076574 */
            ii(0x1009_d20e, 4); mov(dx, memw_a32[ds, eax + 0x1a]);      /* mov dx, [eax+0x1a] */
            ii(0x1009_d212, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d215, 4); mov(memw_a32[ds, eax + 0x17], dx);      /* mov [eax+0x17], dx */
            ii(0x1009_d219, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d21c, 3); add(eax, 0x13);                         /* add eax, 0x13 */
            ii(0x1009_d21f, 5); calld(0x1007_6574, -0x2_6cb0);          /* call 0x10076574 */
            ii(0x1009_d224, 4); mov(dx, memw_a32[ds, eax + 0x1c]);      /* mov dx, [eax+0x1c] */
            ii(0x1009_d228, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d22b, 4); mov(memw_a32[ds, eax + 0x19], dx);      /* mov [eax+0x19], dx */
            ii(0x1009_d22f, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1009_d232, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1009_d235, 3); mov(memd_a32[ds, edx + 0x1b], eax);     /* mov [edx+0x1b], eax */
            ii(0x1009_d238, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1009_d23b, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x1009_d23e, 4); mov(memw_a32[ds, edx + 0x1f], ax);      /* mov [edx+0x1f], ax */
            ii(0x1009_d242, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d245, 6); mov(memw_a32[ds, eax + 0x3f], 0);       /* mov word [eax+0x3f], 0x0 */
            ii(0x1009_d24b, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d24e, 6); mov(memw_a32[ds, eax + 0x41], 0);       /* mov word [eax+0x41], 0x0 */
            ii(0x1009_d254, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d257, 6); mov(memw_a32[ds, eax + 0x43], 0);       /* mov word [eax+0x43], 0x0 */
            ii(0x1009_d25d, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x1009_d260, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x1009_d263, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x1009_d266, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1009_d268, 1); popd(ebp);                              /* pop ebp */
            ii(0x1009_d269, 1); popd(edi);                              /* pop edi */
            ii(0x1009_d26a, 1); popd(esi);                              /* pop esi */
            ii(0x1009_d26b, 1); retd(); return;                         /* ret */
        }
    }
}
