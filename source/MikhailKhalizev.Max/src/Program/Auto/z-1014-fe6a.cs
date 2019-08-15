using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("948c8fc9-3f51-4e86-86e5-dcaa50170bc8")]
        public void Method_1014_fe6a()
        {
            ii(0x1014_fe6a, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1014_fe6f, 5); calld(Definitions.sys_check_available_stack_size, 0x1_5ede); /* call 0x10165d52 */
            ii(0x1014_fe74, 1); pushd(ebx);                             /* push ebx */
            ii(0x1014_fe75, 1); pushd(ecx);                             /* push ecx */
            ii(0x1014_fe76, 1); pushd(esi);                             /* push esi */
            ii(0x1014_fe77, 1); pushd(edi);                             /* push edi */
            ii(0x1014_fe78, 1); pushd(ebp);                             /* push ebp */
            ii(0x1014_fe79, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1014_fe7b, 6); sub(esp, 0xc);                          /* sub esp, 0xc */
            ii(0x1014_fe81, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x1014_fe84, 3); mov(memd_a32[ss, ebp - 0x4], edx);      /* mov [ebp-0x4], edx */
            ii(0x1014_fe87, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fe8a, 3); mov(eax, memd_a32[ds, eax + 0x6]);      /* mov eax, [eax+0x6] */
            ii(0x1014_fe8d, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x1014_fe90, 3); imul(eax, eax, 0x33);                   /* imul eax, eax, 0x33 */
            ii(0x1014_fe93, 7); cmp(memb_a32[ds, eax + 0x101c_81d5], 0x2); /* cmp byte [eax+0x101c81d5], 0x2 */
            ii(0x1014_fe9a, 6); if(jnzd(0x1014_ff2e, 0x8e)) goto l_0x1014_ff2e; /* jnz 0x1014ff2e */
            ii(0x1014_fea0, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_fea3, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_fea6, 4); add(memw_a32[ds, edx + 0x52], ax);      /* add [edx+0x52], ax */
            ii(0x1014_feaa, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_feac, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_feaf, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_feb2, 5); calld(0x1013_ad71, -0x1_5146);          /* call 0x1013ad71 */
            ii(0x1014_feb7, 2); test(al, al);                           /* test al, al */
            ii(0x1014_feb9, 2); if(jzd(0x1014_ff2e, 0x73)) goto l_0x1014_ff2e; /* jz 0x1014ff2e */
            ii(0x1014_febb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_febe, 5); calld(0x1007_623c, -0xd_9c87);          /* call 0x1007623c */
            ii(0x1014_fec3, 4); mov(ax, memw_a32[ds, eax + 0x19]);      /* mov ax, [eax+0x19] */
            ii(0x1014_fec7, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x1014_feca, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fecd, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_fed0, 5); calld(0x1007_6884, -0xd_9651);          /* call 0x10076884 */
            ii(0x1014_fed5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_fed7, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_feda, 4); add(memw_a32[ds, edx + 0xa], ax);       /* add [edx+0xa], ax */
            ii(0x1014_fede, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_fee1, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fee5, 4); cmp(ax, memw_a32[ss, ebp - 0xc]);       /* cmp ax, [ebp-0xc] */
            ii(0x1014_fee9, 2); if(jled(0x1014_ff2e, 0x43)) goto l_0x1014_ff2e; /* jle 0x1014ff2e */
            ii(0x1014_feeb, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_feee, 4); mov(ax, memw_a32[ds, eax + 0x52]);      /* mov ax, [eax+0x52] */
            ii(0x1014_fef2, 3); sub(eax, memd_a32[ss, ebp - 0xc]);      /* sub eax, [ebp-0xc] */
            ii(0x1014_fef5, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1014_fef8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x1014_fefb, 3); mov(edx, memd_a32[ss, ebp - 0x8]);      /* mov edx, [ebp-0x8] */
            ii(0x1014_fefe, 4); mov(memw_a32[ds, edx + 0x52], ax);      /* mov [edx+0x52], ax */
            ii(0x1014_ff02, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ff05, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ff08, 5); calld(0x1007_6884, -0xd_9689);          /* call 0x10076884 */
            ii(0x1014_ff0d, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x1014_ff0f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1014_ff12, 4); sub(memw_a32[ds, edx + 0xa], ax);       /* sub [edx+0xa], ax */
            ii(0x1014_ff16, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1014_ff18, 4); movsx(ebx, memw_a32[ss, ebp - 0x4]);    /* movsx ebx, word [ebp-0x4] */
            ii(0x1014_ff1c, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x1014_ff1e, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x1014_ff21, 3); add(eax, 0x70);                         /* add eax, 0x70 */
            ii(0x1014_ff24, 5); calld(0x1015_5314, 0x53eb);             /* call 0x10155314 */
            ii(0x1014_ff29, 5); calld(0x100d_7a9c, -0x7_8492);          /* call 0x100d7a9c */
        l_0x1014_ff2e:
            ii(0x1014_ff2e, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1014_ff30, 1); popd(ebp);                              /* pop ebp */
            ii(0x1014_ff31, 1); popd(edi);                              /* pop edi */
            ii(0x1014_ff32, 1); popd(esi);                              /* pop esi */
            ii(0x1014_ff33, 1); popd(ecx);                              /* pop ecx */
            ii(0x1014_ff34, 1); popd(ebx);                              /* pop ebx */
            ii(0x1014_ff35, 1); retd(); return;                         /* ret */
        }
    }
}
