using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("dc2db667-ec6b-49a2-a520-479e22f9fc2f")]
        public void Method_1015_410e()
        {
            ii(0x1015_410e, 5); pushd(0x24);                            /* push 0x24 */
            ii(0x1015_4113, 5); calld(Definitions.sys_check_available_stack_size, 0x1_1c3a); /* call 0x10165d52 */
            ii(0x1015_4118, 1); pushd(ebx);                             /* push ebx */
            ii(0x1015_4119, 1); pushd(ecx);                             /* push ecx */
            ii(0x1015_411a, 1); pushd(edx);                             /* push edx */
            ii(0x1015_411b, 1); pushd(esi);                             /* push esi */
            ii(0x1015_411c, 1); pushd(edi);                             /* push edi */
            ii(0x1015_411d, 1); pushd(ebp);                             /* push ebp */
            ii(0x1015_411e, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x1015_4120, 6); sub(esp, 0x8);                          /* sub esp, 0x8 */
            ii(0x1015_4126, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x1015_4129, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_412c, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_412f, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_4134, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x1015_4136, 2); if(jnzd(0x1015_4149, 0x11)) goto l_0x1015_4149; /* jnz 0x10154149 */
            ii(0x1015_4138, 5); mov(edx, 0x101c_37bc);                  /* mov edx, 0x101c37bc */
            ii(0x1015_413d, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4140, 5); calld(0x1007_6d98, -0xd_d3ad);          /* call 0x10076d98 */
            ii(0x1015_4145, 2); test(al, al);                           /* test al, al */
            ii(0x1015_4147, 2); if(jnzd(0x1015_414b, 0x2)) goto l_0x1015_414b; /* jnz 0x1015414b */
        l_0x1015_4149:
            ii(0x1015_4149, 2); jmpd(0x1015_4166, 0x1b); goto l_0x1015_4166; /* jmp 0x10154166 */
        l_0x1015_414b:
            ii(0x1015_414b, 5); calld(0x1010_2bf8, -0x5_1558);          /* call 0x10102bf8 */
            ii(0x1015_4150, 2); xor(ecx, ecx);                          /* xor ecx, ecx */
            ii(0x1015_4152, 2); mov(cl, al);                            /* mov cl, al */
            ii(0x1015_4154, 5); mov(ebx, 0x11);                         /* mov ebx, 0x11 */
            ii(0x1015_4159, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x1015_415c, 5); mov(eax, 0x101c_7278);                  /* mov eax, 0x101c7278 */
            ii(0x1015_4161, 5); calld(0x1013_d5c0, -0x1_6ba6);          /* call 0x1013d5c0 */
        l_0x1015_4166:
            ii(0x1015_4166, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4169, 5); calld(0x1014_9fa8, -0xa1c6);            /* call 0x10149fa8 */
            ii(0x1015_416e, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4171, 3); mov(dl, memb_a32[ds, eax + 0x5e]);      /* mov dl, [eax+0x5e] */
            ii(0x1015_4174, 2); inc(dl);                                /* inc dl */
            ii(0x1015_4176, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4179, 3); and(dl, 0x3f);                          /* and dl, 0x3f */
            ii(0x1015_417c, 3); mov(memb_a32[ds, eax + 0x5e], dl);      /* mov [eax+0x5e], dl */
            ii(0x1015_417f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4182, 3); mov(al, memb_a32[ds, eax + 0x5e]);      /* mov al, [eax+0x5e] */
            ii(0x1015_4185, 5); and(eax, 0xff);                         /* and eax, 0xff */
            ii(0x1015_418a, 3); cmp(eax, 0x8);                          /* cmp eax, 0x8 */
            ii(0x1015_418d, 2); if(jgd(0x1015_41bb, 0x2c)) goto l_0x1015_41bb; /* jg 0x101541bb */
            ii(0x1015_418f, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_4192, 8); add(memw_a32[ds, eax + 0xd9], 0x8);     /* add word [eax+0xd9], 0x8 */
            ii(0x1015_419a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_419d, 8); add(memw_a32[ds, eax + 0xdb], 0x8);     /* add word [eax+0xdb], 0x8 */
            ii(0x1015_41a5, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_41a8, 5); calld(0x1014_9cd1, -0xa4dc);            /* call 0x10149cd1 */
            ii(0x1015_41ad, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_41b0, 5); calld(0x1014_9fa8, -0xa20d);            /* call 0x10149fa8 */
            ii(0x1015_41b5, 4); mov(memb_a32[ss, ebp - 0x8], 0);        /* mov byte [ebp-0x8], 0x0 */
            ii(0x1015_41b9, 2); jmpd(0x1015_41ce, 0x13); goto l_0x1015_41ce; /* jmp 0x101541ce */
        l_0x1015_41bb:
            ii(0x1015_41bb, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_41be, 4); and(memb_a32[ds, eax + 0x14], -0x2 /* 0xfe */); /* and byte [eax+0x14], 0xfe */
            ii(0x1015_41c2, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x1015_41c5, 5); calld(0x1015_48ba, 0x6f0);              /* call 0x101548ba */
            ii(0x1015_41ca, 4); mov(memb_a32[ss, ebp - 0x8], 0x1);      /* mov byte [ebp-0x8], 0x1 */
        l_0x1015_41ce:
            ii(0x1015_41ce, 3); mov(al, memb_a32[ss, ebp - 0x8]);       /* mov al, [ebp-0x8] */
            ii(0x1015_41d1, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x1015_41d3, 1); popd(ebp);                              /* pop ebp */
            ii(0x1015_41d4, 1); popd(edi);                              /* pop edi */
            ii(0x1015_41d5, 1); popd(esi);                              /* pop esi */
            ii(0x1015_41d6, 1); popd(edx);                              /* pop edx */
            ii(0x1015_41d7, 1); popd(ecx);                              /* pop ecx */
            ii(0x1015_41d8, 1); popd(ebx);                              /* pop ebx */
            ii(0x1015_41d9, 1); retd(); return;                         /* ret */
        }
    }
}
