using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("74f5fb08-9249-41b2-8a36-78c2876de713")]
        public void Method_100d_82fd()
        {
            ii(0x100d_82fd, 5); pushd(0x48);                            /* push 0x48 */
            ii(0x100d_8302, 5); calld(Definitions.sys_check_available_stack_size, 0x8da4b); /* call 0x10165d52 */
            ii(0x100d_8307, 1); pushd(esi);                             /* push esi */
            ii(0x100d_8308, 1); pushd(edi);                             /* push edi */
            ii(0x100d_8309, 1); pushd(ebp);                             /* push ebp */
            ii(0x100d_830a, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100d_830c, 6); sub(esp, 0x34);                         /* sub esp, 0x34 */
            ii(0x100d_8312, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100d_8315, 3); mov(memd_a32[ss, ebp - 0xc], edx);      /* mov [ebp-0xc], edx */
            ii(0x100d_8318, 3); mov(memd_a32[ss, ebp - 0x8], ebx);      /* mov [ebp-0x8], ebx */
            ii(0x100d_831b, 3); mov(memd_a32[ss, ebp - 0x4], ecx);      /* mov [ebp-0x4], ecx */
            ii(0x100d_831e, 3); mov(eax, memd_a32[ss, ebp + 0x18]);     /* mov eax, [ebp+0x18] */
            ii(0x100d_8321, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_8324, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x100d_8326, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8329, 6); mov(memw_a32[ds, eax + 0x19], 0x1);     /* mov word [eax+0x19], 0x1 */
            ii(0x100d_832f, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8332, 7); mov(memd_a32[ds, eax + 0x1b], 0);       /* mov dword [eax+0x1b], 0x0 */
            ii(0x100d_8339, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100d_833c, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_833f, 4); mov(memw_a32[ds, edx + 0x4], ax);       /* mov [edx+0x4], ax */
            ii(0x100d_8343, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_8348, 5); calld(Definitions.sys_new, 0x8dab3);    /* call 0x10165e00 */
            ii(0x100d_834d, 3); mov(memd_a32[ss, ebp - 0x14], eax);     /* mov [ebp-0x14], eax */
            ii(0x100d_8350, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_8353, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100d_8356, 4); cmp(memd_a32[ss, ebp - 0x18], 0);       /* cmp dword [ebp-0x18], 0x0 */
            ii(0x100d_835a, 2); if(jzd(0x100d_8389, 0x2d)) goto l_0x100d_8389; /* jz 0x100d8389 */
            ii(0x100d_835c, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_8360, 1); pushd(eax);                             /* push eax */
            ii(0x100d_8361, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100d_8364, 5); add(eax, 0x12);                         /* add eax, 0x12 */
            ii(0x100d_8369, 3); movsx(ecx, ax);                         /* movsx ecx, ax */
            ii(0x100d_836c, 5); mov(ebx, 0x13b);                        /* mov ebx, 0x13b */
            ii(0x100d_8371, 5); mov(edx, 0x13a);                        /* mov edx, 0x13a */
            ii(0x100d_8376, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100d_8379, 5); calld(Definitions.my_ctor_c17, -0x9f6f); /* call 0x100ce40f */
            ii(0x100d_837e, 3); mov(memd_a32[ss, ebp - 0x1c], eax);     /* mov [ebp-0x1c], eax */
            ii(0x100d_8381, 3); mov(eax, memd_a32[ss, ebp - 0x1c]);     /* mov eax, [ebp-0x1c] */
            ii(0x100d_8384, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100d_8387, 2); jmpd(0x100d_838f, 0x6); goto l_0x100d_838f; /* jmp 0x100d838f */
        l_0x100d_8389:
            ii(0x100d_8389, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100d_838c, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
        l_0x100d_838f:
            ii(0x100d_838f, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100d_8392, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_8395, 3); mov(memd_a32[ds, edx + 0x6], eax);      /* mov [edx+0x6], eax */
            ii(0x100d_8398, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100d_839d, 5); calld(Definitions.sys_new, 0x8da5e);    /* call 0x10165e00 */
            ii(0x100d_83a2, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100d_83a5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_83a8, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100d_83ab, 4); cmp(memd_a32[ss, ebp - 0x28], 0);       /* cmp dword [ebp-0x28], 0x0 */
            ii(0x100d_83af, 2); if(jzd(0x100d_83d7, 0x26)) goto l_0x100d_83d7; /* jz 0x100d83d7 */
            ii(0x100d_83b1, 4); movsx(eax, memw_a32[ss, ebp - 0x4]);    /* movsx eax, word [ebp-0x4] */
            ii(0x100d_83b5, 1); pushd(eax);                             /* push eax */
            ii(0x100d_83b6, 4); movsx(ecx, memw_a32[ss, ebp - 0x8]);    /* movsx ecx, word [ebp-0x8] */
            ii(0x100d_83ba, 5); mov(ebx, 0x13e);                        /* mov ebx, 0x13e */
            ii(0x100d_83bf, 5); mov(edx, 0x13d);                        /* mov edx, 0x13d */
            ii(0x100d_83c4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100d_83c7, 5); calld(Definitions.my_ctor_c17, -0x9fbd); /* call 0x100ce40f */
            ii(0x100d_83cc, 3); mov(memd_a32[ss, ebp - 0x2c], eax);     /* mov [ebp-0x2c], eax */
            ii(0x100d_83cf, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100d_83d2, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
            ii(0x100d_83d5, 2); jmpd(0x100d_83dd, 0x6); goto l_0x100d_83dd; /* jmp 0x100d83dd */
        l_0x100d_83d7:
            ii(0x100d_83d7, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100d_83da, 3); mov(memd_a32[ss, ebp - 0x30], eax);     /* mov [ebp-0x30], eax */
        l_0x100d_83dd:
            ii(0x100d_83dd, 3); mov(eax, memd_a32[ss, ebp - 0x30]);     /* mov eax, [ebp-0x30] */
            ii(0x100d_83e0, 3); mov(edx, memd_a32[ss, ebp - 0x10]);     /* mov edx, [ebp-0x10] */
            ii(0x100d_83e3, 3); mov(memd_a32[ds, edx + 0xa], eax);      /* mov [edx+0xa], eax */
            ii(0x100d_83e6, 4); movsx(edx, memw_a32[ss, ebp + 0x10]);   /* movsx edx, word [ebp+0x10] */
            ii(0x100d_83ea, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_83ed, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_83f0, 5); calld(0x100d_5134, -0x32c1);            /* call 0x100d5134 */
            ii(0x100d_83f5, 5); mov(edx, 0x13c);                        /* mov edx, 0x13c */
            ii(0x100d_83fa, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_83fd, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_8400, 5); calld(0x100c_f2ba, -0x914b);            /* call 0x100cf2ba */
            ii(0x100d_8405, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_8408, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_840b, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_840e, 5); calld(0x100c_e92d, -0x9ae6);            /* call 0x100ce92d */
            ii(0x100d_8413, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_8416, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8419, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x100d_841c, 5); calld(0x100c_f85c, -0x8bc5);            /* call 0x100cf85c */
            ii(0x100d_8421, 4); movsx(edx, memw_a32[ss, ebp + 0x14]);   /* movsx edx, word [ebp+0x14] */
            ii(0x100d_8425, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8428, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_842b, 5); calld(0x100d_5134, -0x32fc);            /* call 0x100d5134 */
            ii(0x100d_8430, 5); mov(edx, 0x13f);                        /* mov edx, 0x13f */
            ii(0x100d_8435, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8438, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_843b, 5); calld(0x100c_f2ba, -0x9186);            /* call 0x100cf2ba */
            ii(0x100d_8440, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_8443, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8446, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_8449, 5); calld(0x100c_e92d, -0x9b21);            /* call 0x100ce92d */
            ii(0x100d_844e, 3); mov(edx, memd_a32[ss, ebp - 0xc]);      /* mov edx, [ebp-0xc] */
            ii(0x100d_8451, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_8454, 3); mov(eax, memd_a32[ds, eax + 0xa]);      /* mov eax, [eax+0xa] */
            ii(0x100d_8457, 5); calld(0x100c_f85c, -0x8c00);            /* call 0x100cf85c */
            ii(0x100d_845c, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100d_845f, 3); mov(memd_a32[ss, ebp - 0x34], eax);     /* mov [ebp-0x34], eax */
            ii(0x100d_8462, 3); mov(eax, memd_a32[ss, ebp - 0x34]);     /* mov eax, [ebp-0x34] */
            ii(0x100d_8465, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100d_8467, 1); popd(ebp);                              /* pop ebp */
            ii(0x100d_8468, 1); popd(edi);                              /* pop edi */
            ii(0x100d_8469, 1); popd(esi);                              /* pop esi */
            ii(0x100d_846a, 3); retd(0xc); return;                      /* ret 0xc */
        }
    }
}
