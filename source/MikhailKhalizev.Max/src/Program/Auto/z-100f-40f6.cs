using System;
using MikhailKhalizev.Processor.x86.BinToCSharp;

namespace MikhailKhalizev.Max.Program
{
    public partial class RawProgram
    {
        [MethodInfo("0x100f_40f6-50c52533")]
        public void Method_100f_40f6()
        {
            ii(0x100f_40f6, 5); pushd(0x84);                            /* push 0x84 */
            ii(0x100f_40fb, 5); calld(Definitions.sys_check_available_stack_size, 0x7_1c52); /* call 0x10165d52 */
            ii(0x100f_4100, 1); pushd(ebx);                             /* push ebx */
            ii(0x100f_4101, 1); pushd(ecx);                             /* push ecx */
            ii(0x100f_4102, 1); pushd(edx);                             /* push edx */
            ii(0x100f_4103, 1); pushd(esi);                             /* push esi */
            ii(0x100f_4104, 1); pushd(edi);                             /* push edi */
            ii(0x100f_4105, 1); pushd(ebp);                             /* push ebp */
            ii(0x100f_4106, 2); mov(ebp, esp);                          /* mov ebp, esp */
            ii(0x100f_4108, 6); sub(esp, 0x58);                         /* sub esp, 0x58 */
            ii(0x100f_410e, 3); mov(memd_a32[ss, ebp - 0x4], eax);      /* mov [ebp-0x4], eax */
            ii(0x100f_4111, 5); mov(eax, 0x26);                         /* mov eax, 0x26 */
            ii(0x100f_4116, 5); calld(0x100e_883d, -0xb8de);            /* call 0x100e883d */
            ii(0x100f_411b, 3); mov(memd_a32[ss, ebp - 0x28], eax);     /* mov [ebp-0x28], eax */
            ii(0x100f_411e, 5); mov(eax, 0x1);                          /* mov eax, 0x1 */
            ii(0x100f_4123, 5); calld(0x100e_883d, -0xb8eb);            /* call 0x100e883d */
            ii(0x100f_4128, 3); mov(memd_a32[ss, ebp - 0x24], eax);     /* mov [ebp-0x24], eax */
            ii(0x100f_412b, 7); mov(memd_a32[ss, ebp - 0x1c], 0);       /* mov dword [ebp-0x1c], 0x0 */
            ii(0x100f_4132, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_4135, 4); cmp(memb_a32[ds, eax + 0x3d], 0x1a);    /* cmp byte [eax+0x3d], 0x1a */
            ii(0x100f_4139, 2); if(jzd(0x100f_4148, 0xd)) goto l_0x100f_4148; /* jz 0x100f4148 */
            ii(0x100f_413b, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_413e, 5); calld(0x1010_1103, 0xcfc0);             /* call 0x10101103 */
            ii(0x100f_4143, 1); cwde();                                 /* cwde */
            ii(0x100f_4144, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_4146, 2); if(jnzd(0x100f_414a, 0x2)) goto l_0x100f_414a; /* jnz 0x100f414a */
        l_0x100f_4148:
            ii(0x100f_4148, 2); jmpd(0x100f_415e, 0x14); goto l_0x100f_415e; /* jmp 0x100f415e */
        l_0x100f_414a:
            ii(0x100f_414a, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_414d, 4); test(memb_a32[ds, eax + 0x13], 0x1);    /* test byte [eax+0x13], 0x1 */
            ii(0x100f_4151, 2); if(jzd(0x100f_415c, 0x9)) goto l_0x100f_415c; /* jz 0x100f415c */
            ii(0x100f_4153, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_4156, 4); cmp(memb_a32[ds, eax + 0x3e], 0x1f);    /* cmp byte [eax+0x3e], 0x1f */
            ii(0x100f_415a, 2); if(jzd(0x100f_415e, 0x2)) goto l_0x100f_415e; /* jz 0x100f415e */
        l_0x100f_415c:
            ii(0x100f_415c, 2); jmpd(0x100f_416a, 0xc); goto l_0x100f_416a; /* jmp 0x100f416a */
        l_0x100f_415e:
            ii(0x100f_415e, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100f_4165, 5); jmpd(0x100f_4480, 0x316); goto l_0x100f_4480; /* jmp 0x100f4480 */
        l_0x100f_416a:
            ii(0x100f_416a, 7); mov(memb_a32[ds, 0x101c_37e4], 0);      /* mov byte [0x101c37e4], 0x0 */
            ii(0x100f_4171, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_4174, 3); mov(ebx, memd_a32[ds, eax + 0xa]);      /* mov ebx, [eax+0xa] */
            ii(0x100f_4177, 5); mov(edx, 0x101c_37e4);                  /* mov edx, 0x101c37e4 */
            ii(0x100f_417c, 3); mov(eax, memd_a32[ss, ebp - 0x4]);      /* mov eax, [ebp-0x4] */
            ii(0x100f_417f, 2); calld_abs(memd_a32[ds, ebx]);           /* call dword [ebx] */
            ii(0x100f_4181, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_4183, 5); mov(al, memb_a32[ds, 0x101c_37e4]);     /* mov al, [0x101c37e4] */
            ii(0x100f_4188, 2); test(eax, eax);                         /* test eax, eax */
            ii(0x100f_418a, 2); if(jnzd(0x100f_4198, 0xc)) goto l_0x100f_4198; /* jnz 0x100f4198 */
            ii(0x100f_418c, 7); mov(memd_a32[ss, ebp - 0x2c], 0);       /* mov dword [ebp-0x2c], 0x0 */
            ii(0x100f_4193, 5); jmpd(0x100f_4480, 0x2e8); goto l_0x100f_4480; /* jmp 0x100f4480 */
        l_0x100f_4198:
            ii(0x100f_4198, 5); mov(eax, 0xb1);                         /* mov eax, 0xb1 */
            ii(0x100f_419d, 5); calld(Definitions.my_get_res_data_by_id, 0x3_fe36); /* call 0x10133fd8 */
            ii(0x100f_41a2, 3); mov(memd_a32[ss, ebp - 0x20], eax);     /* mov [ebp-0x20], eax */
            ii(0x100f_41a5, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_41a8, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_41ab, 3); mov(memd_a32[ss, ebp - 0xc], eax);      /* mov [ebp-0xc], eax */
            ii(0x100f_41ae, 3); mov(eax, memd_a32[ss, ebp - 0x20]);     /* mov eax, [ebp-0x20] */
            ii(0x100f_41b1, 4); mov(ax, memw_a32[ds, eax + 0x2]);       /* mov ax, [eax+0x2] */
            ii(0x100f_41b5, 3); mov(memd_a32[ss, ebp - 0x8], eax);      /* mov [ebp-0x8], eax */
            ii(0x100f_41b8, 3); mov(eax, memd_a32[ss, ebp - 0xc]);      /* mov eax, [ebp-0xc] */
            ii(0x100f_41bb, 5); add(eax, 0x6);                          /* add eax, 0x6 */
            ii(0x100f_41c0, 6); mov(memw_a32[ds, 0x101c_387f], ax);     /* mov [0x101c387f], ax */
            ii(0x100f_41c6, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_41c8, 6); mov(dl, memb_a32[ds, 0x101c_37e4]);     /* mov dl, [0x101c37e4] */
            ii(0x100f_41ce, 4); imul(edx, memd_a32[ss, ebp - 0x8]);     /* imul edx, [ebp-0x8] */
            ii(0x100f_41d2, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_41d4, 5); mov(al, memb_a32[ds, 0x101c_37e4]);     /* mov al, [0x101c37e4] */
            ii(0x100f_41d9, 1); inc(eax);                               /* inc eax */
            ii(0x100f_41da, 3); imul(eax, eax, 0x3);                    /* imul eax, eax, 0x3 */
            ii(0x100f_41dd, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_41df, 7); mov(memw_a32[ds, 0x101c_3881], dx);     /* mov [0x101c3881], dx */
            ii(0x100f_41e6, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_41e9, 3); mov(eax, memd_a32[ds, edx + 0x14]);     /* mov eax, [edx+0x14] */
            ii(0x100f_41ec, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_41ef, 3); add(eax, 0x20);                         /* add eax, 0x20 */
            ii(0x100f_41f2, 3); shl(eax, 0x10);                         /* shl eax, 0x10 */
            ii(0x100f_41f5, 2); mov(edx, eax);                          /* mov edx, eax */
            ii(0x100f_41f7, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_41f9, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_41fc, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100f_4202, 6); mov(edx, memd_a32[ds, 0x101c_38fa]);    /* mov edx, [0x101c38fa] */
            ii(0x100f_4208, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_420b, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_420d, 3); mov(memd_a32[ss, ebp - 0x10], eax);     /* mov [ebp-0x10], eax */
            ii(0x100f_4210, 3); mov(edx, memd_a32[ss, ebp - 0x4]);      /* mov edx, [ebp-0x4] */
            ii(0x100f_4213, 3); mov(edx, memd_a32[ds, edx + 0x16]);     /* mov edx, [edx+0x16] */
            ii(0x100f_4216, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_4219, 3); shl(edx, 0x10);                         /* shl edx, 0x10 */
            ii(0x100f_421c, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_421e, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_4221, 6); idiv(memd_a32[ds, 0x101c_38c4]);        /* idiv dword [0x101c38c4] */
            ii(0x100f_4227, 6); mov(edx, memd_a32[ds, 0x101c_38fc]);    /* mov edx, [0x101c38fc] */
            ii(0x100f_422d, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_4230, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_4232, 2); mov(ebx, eax);                          /* mov ebx, eax */
            ii(0x100f_4234, 6); mov(edx, memd_a32[ds, 0x101c_387f]);    /* mov edx, [0x101c387f] */
            ii(0x100f_423a, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_423d, 2); mov(eax, edx);                          /* mov eax, edx */
            ii(0x100f_423f, 3); sar(edx, 0x1f);                         /* sar edx, 0x1f */
            ii(0x100f_4242, 2); sub(eax, edx);                          /* sub eax, edx */
            ii(0x100f_4244, 2); sar(eax, 0x1);                          /* sar eax, 1 */
            ii(0x100f_4246, 2); sub(ebx, eax);                          /* sub ebx, eax */
            ii(0x100f_4248, 3); mov(memd_a32[ss, ebp - 0x18], ebx);     /* mov [ebp-0x18], ebx */
            ii(0x100f_424b, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_424e, 3); mov(ax, memw_a32[ds, eax]);             /* mov ax, [eax] */
            ii(0x100f_4251, 3); add(memd_a32[ss, ebp - 0x10], eax);     /* add [ebp-0x10], eax */
            ii(0x100f_4254, 5); mov(eax, memd_a32[ds, 0x101c_387d]);    /* mov eax, [0x101c387d] */
            ii(0x100f_4259, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_425c, 4); movsx(edx, memw_a32[ss, ebp - 0x10]);   /* movsx edx, word [ebp-0x10] */
            ii(0x100f_4260, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_4262, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_4265, 3); cmp(edx, memd_a32[ds, eax + 0x8]);      /* cmp edx, [eax+0x8] */
            ii(0x100f_4268, 2); if(jled(0x100f_427a, 0x10)) goto l_0x100f_427a; /* jle 0x100f427a */
            ii(0x100f_426a, 6); mov(ax, memw_a32[ds, 0x101c_387f]);     /* mov ax, [0x101c387f] */
            ii(0x100f_4270, 7); add(ax, memw_a32[ds, 0x101c_38c0]);     /* add ax, [0x101c38c0] */
            ii(0x100f_4277, 3); sub(memd_a32[ss, ebp - 0x10], eax);     /* sub [ebp-0x10], eax */
        l_0x100f_427a:
            ii(0x100f_427a, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_427d, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100f_4281, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x100f_4284, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_4288, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_428b, 3); cmp(edx, memd_a32[ds, eax + 0x4]);      /* cmp edx, [eax+0x4] */
            ii(0x100f_428e, 2); if(jged(0x100f_429c, 0xc)) goto l_0x100f_429c; /* jge 0x100f429c */
            ii(0x100f_4290, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_4293, 4); mov(ax, memw_a32[ds, eax + 0x4]);       /* mov ax, [eax+0x4] */
            ii(0x100f_4297, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
            ii(0x100f_429a, 2); jmpd(0x100f_42c3, 0x27); goto l_0x100f_42c3; /* jmp 0x100f42c3 */
        l_0x100f_429c:
            ii(0x100f_429c, 5); mov(eax, memd_a32[ds, 0x101c_387f]);    /* mov eax, [0x101c387f] */
            ii(0x100f_42a1, 3); sar(eax, 0x10);                         /* sar eax, 0x10 */
            ii(0x100f_42a4, 4); movsx(edx, memw_a32[ss, ebp - 0x18]);   /* movsx edx, word [ebp-0x18] */
            ii(0x100f_42a8, 2); add(edx, eax);                          /* add edx, eax */
            ii(0x100f_42aa, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_42ad, 3); cmp(edx, memd_a32[ds, eax + 0xc]);      /* cmp edx, [eax+0xc] */
            ii(0x100f_42b0, 2); if(jled(0x100f_42c3, 0x11)) goto l_0x100f_42c3; /* jle 0x100f42c3 */
            ii(0x100f_42b2, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_42b5, 4); mov(ax, memw_a32[ds, eax + 0xc]);       /* mov ax, [eax+0xc] */
            ii(0x100f_42b9, 7); sub(ax, memw_a32[ds, 0x101c_3881]);     /* sub ax, [0x101c3881] */
            ii(0x100f_42c0, 3); mov(memd_a32[ss, ebp - 0x18], eax);     /* mov [ebp-0x18], eax */
        l_0x100f_42c3:
            ii(0x100f_42c3, 4); movsx(eax, memw_a32[ss, ebp - 0x10]);   /* movsx eax, word [ebp-0x10] */
            ii(0x100f_42c7, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100f_42ca, 2); mov(memd_a32[ds, edx], eax);            /* mov [edx], eax */
            ii(0x100f_42cc, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_42d0, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100f_42d3, 3); mov(memd_a32[ds, edx + 0x4], eax);      /* mov [edx+0x4], eax */
            ii(0x100f_42d6, 6); mov(edx, memd_a32[ds, 0x101c_387d]);    /* mov edx, [0x101c387d] */
            ii(0x100f_42dc, 3); sar(edx, 0x10);                         /* sar edx, 0x10 */
            ii(0x100f_42df, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_42e2, 2); mov(ebx, memd_a32[ds, eax]);            /* mov ebx, [eax] */
            ii(0x100f_42e4, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_42e7, 2); add(edx, ebx);                          /* add edx, ebx */
            ii(0x100f_42e9, 3); mov(memd_a32[ds, eax + 0x8], edx);      /* mov [eax+0x8], edx */
            ii(0x100f_42ec, 6); mov(ebx, memd_a32[ds, 0x101c_387f]);    /* mov ebx, [0x101c387f] */
            ii(0x100f_42f2, 3); sar(ebx, 0x10);                         /* sar ebx, 0x10 */
            ii(0x100f_42f5, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_42f8, 3); mov(edx, memd_a32[ds, eax + 0x4]);      /* mov edx, [eax+0x4] */
            ii(0x100f_42fb, 3); mov(eax, memd_a32[ss, ebp - 0x24]);     /* mov eax, [ebp-0x24] */
            ii(0x100f_42fe, 2); add(ebx, edx);                          /* add ebx, edx */
            ii(0x100f_4300, 3); mov(memd_a32[ds, eax + 0xc], ebx);      /* mov [eax+0xc], ebx */
            ii(0x100f_4303, 3); mov(eax, memd_a32[ss, ebp - 0x10]);     /* mov eax, [ebp-0x10] */
            ii(0x100f_4306, 6); mov(memw_a32[ds, 0x101c_387b], ax);     /* mov [0x101c387b], ax */
            ii(0x100f_430c, 3); mov(eax, memd_a32[ss, ebp - 0x18]);     /* mov eax, [ebp-0x18] */
            ii(0x100f_430f, 6); mov(memw_a32[ds, 0x101c_387d], ax);     /* mov [0x101c387d], ax */
            ii(0x100f_4315, 4); add(memd_a32[ss, ebp - 0x10], 0x3);     /* add dword [ebp-0x10], 0x3 */
            ii(0x100f_4319, 4); add(memd_a32[ss, ebp - 0x18], 0x3);     /* add dword [ebp-0x18], 0x3 */
            ii(0x100f_431d, 5); mov(eax, 0x2);                          /* mov eax, 0x2 */
            ii(0x100f_4322, 5); calld(/* sys */ 0x1016_a24c, 0x7_5f25); /* call 0x1016a24c */
            ii(0x100f_4327, 7); mov(memd_a32[ss, ebp - 0x14], 0);       /* mov dword [ebp-0x14], 0x0 */
            ii(0x100f_432e, 2); jmpd(0x100f_4336, 0x6); goto l_0x100f_4336; /* jmp 0x100f4336 */
        l_0x100f_4330:
            ii(0x100f_4330, 3); mov(eax, memd_a32[ss, ebp - 0x14]);     /* mov eax, [ebp-0x14] */
            ii(0x100f_4333, 3); inc(memd_a32[ss, ebp - 0x14]);          /* inc dword [ebp-0x14] */
        l_0x100f_4336:
            ii(0x100f_4336, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_433a, 2); xor(eax, eax);                          /* xor eax, eax */
            ii(0x100f_433c, 5); mov(al, memb_a32[ds, 0x101c_37e4]);     /* mov al, [0x101c37e4] */
            ii(0x100f_4341, 2); cmp(edx, eax);                          /* cmp edx, eax */
            ii(0x100f_4343, 6); if(jged(0x100f_446b, 0x122)) goto l_0x100f_446b; /* jge 0x100f446b */
            ii(0x100f_4349, 7); mov(memd_a32[ss, ebp - 0x30], 0xb1);    /* mov dword [ebp-0x30], 0xb1 */
            ii(0x100f_4350, 7); mov(memd_a32[ss, ebp - 0x34], 0xb2);    /* mov dword [ebp-0x34], 0xb2 */
            ii(0x100f_4357, 4); movsx(eax, memw_a32[ss, ebp - 0x14]);   /* movsx eax, word [ebp-0x14] */
            ii(0x100f_435b, 7); cmp(memb_a32[ds, eax + 0x101c_3821], 0); /* cmp byte [eax+0x101c3821], 0x0 */
            ii(0x100f_4362, 2); if(jzd(0x100f_4372, 0xe)) goto l_0x100f_4372; /* jz 0x100f4372 */
            ii(0x100f_4364, 7); mov(memd_a32[ss, ebp - 0x30], 0xb2);    /* mov dword [ebp-0x30], 0xb2 */
            ii(0x100f_436b, 7); mov(memd_a32[ss, ebp - 0x34], 0xb1);    /* mov dword [ebp-0x34], 0xb1 */
        l_0x100f_4372:
            ii(0x100f_4372, 5); mov(eax, 0x38);                         /* mov eax, 0x38 */
            ii(0x100f_4377, 5); calld(Definitions.sys_new, 0x7_1a84);   /* call 0x10165e00 */
            ii(0x100f_437c, 3); mov(memd_a32[ss, ebp - 0x38], eax);     /* mov [ebp-0x38], eax */
            ii(0x100f_437f, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100f_4382, 3); mov(memd_a32[ss, ebp - 0x3c], eax);     /* mov [ebp-0x3c], eax */
            ii(0x100f_4385, 4); cmp(memd_a32[ss, ebp - 0x3c], 0);       /* cmp dword [ebp-0x3c], 0x0 */
            ii(0x100f_4389, 2); if(jzd(0x100f_43af, 0x24)) goto l_0x100f_43af; /* jz 0x100f43af */
            ii(0x100f_438b, 4); movsx(eax, memw_a32[ss, ebp - 0x18]);   /* movsx eax, word [ebp-0x18] */
            ii(0x100f_438f, 1); pushd(eax);                             /* push eax */
            ii(0x100f_4390, 4); movsx(ecx, memw_a32[ss, ebp - 0x10]);   /* movsx ecx, word [ebp-0x10] */
            ii(0x100f_4394, 4); movsx(ebx, memw_a32[ss, ebp - 0x34]);   /* movsx ebx, word [ebp-0x34] */
            ii(0x100f_4398, 4); movsx(edx, memw_a32[ss, ebp - 0x30]);   /* movsx edx, word [ebp-0x30] */
            ii(0x100f_439c, 3); mov(eax, memd_a32[ss, ebp - 0x38]);     /* mov eax, [ebp-0x38] */
            ii(0x100f_439f, 5); calld(Definitions.my_ctor_c17, -0x2_5f95); /* call 0x100ce40f */
            ii(0x100f_43a4, 3); mov(memd_a32[ss, ebp - 0x40], eax);     /* mov [ebp-0x40], eax */
            ii(0x100f_43a7, 3); mov(eax, memd_a32[ss, ebp - 0x40]);     /* mov eax, [ebp-0x40] */
            ii(0x100f_43aa, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
            ii(0x100f_43ad, 2); jmpd(0x100f_43b5, 0x6); goto l_0x100f_43b5; /* jmp 0x100f43b5 */
        l_0x100f_43af:
            ii(0x100f_43af, 3); mov(eax, memd_a32[ss, ebp - 0x3c]);     /* mov eax, [ebp-0x3c] */
            ii(0x100f_43b2, 3); mov(memd_a32[ss, ebp - 0x44], eax);     /* mov [ebp-0x44], eax */
        l_0x100f_43b5:
            ii(0x100f_43b5, 3); mov(eax, memd_a32[ss, ebp - 0x44]);     /* mov eax, [ebp-0x44] */
            ii(0x100f_43b8, 3); mov(memd_a32[ss, ebp - 0x48], eax);     /* mov [ebp-0x48], eax */
            ii(0x100f_43bb, 5); mov(edx, 0x20);                         /* mov edx, 0x20 */
            ii(0x100f_43c0, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_43c3, 5); calld(0x100d_5194, -0x1_f234);          /* call 0x100d5194 */
            ii(0x100f_43c8, 3); lea(eax, ebp - 0x4c);                   /* lea eax, [ebp-0x4c] */
            ii(0x100f_43cb, 5); calld(0x100d_5224, -0x1_f1ac);          /* call 0x100d5224 */
            ii(0x100f_43d0, 1); pushd(eax);                             /* push eax */
            ii(0x100f_43d1, 3); lea(eax, ebp - 0x50);                   /* lea eax, [ebp-0x50] */
            ii(0x100f_43d4, 5); calld(0x100d_5250, -0x1_f189);          /* call 0x100d5250 */
            ii(0x100f_43d9, 1); pushd(eax);                             /* push eax */
            ii(0x100f_43da, 3); lea(eax, ebp - 0x54);                   /* lea eax, [ebp-0x54] */
            ii(0x100f_43dd, 5); calld(0x100d_527c, -0x1_f166);          /* call 0x100d527c */
            ii(0x100f_43e2, 1); pushd(eax);                             /* push eax */
            ii(0x100f_43e3, 3); lea(eax, ebp - 0x58);                   /* lea eax, [ebp-0x58] */
            ii(0x100f_43e6, 5); calld(0x100d_52a8, -0x1_f143);          /* call 0x100d52a8 */
            ii(0x100f_43eb, 1); pushd(eax);                             /* push eax */
            ii(0x100f_43ec, 5); mov(ecx, 0x2);                          /* mov ecx, 0x2 */
            ii(0x100f_43f1, 5); mov(ebx, 0xffff_ffff);                  /* mov ebx, 0xffffffff */
            ii(0x100f_43f6, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_43fa, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_43fd, 6); mov(edx, memd_a32[ds, edx + 0x101c_37f9]); /* mov edx, [edx+0x101c37f9] */
            ii(0x100f_4403, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_4406, 5); calld(0x100c_ef64, -0x2_54a7);          /* call 0x100cef64 */
            ii(0x100f_440b, 3); mov(ebx, memd_a32[ss, ebp - 0x4]);      /* mov ebx, [ebp-0x4] */
            ii(0x100f_440e, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_4412, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_4415, 6); mov(edx, memd_a32[ds, edx + 0x101c_382b]); /* mov edx, [edx+0x101c382b] */
            ii(0x100f_441b, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_441e, 5); calld(0x100c_f824, -0x2_4bff);          /* call 0x100cf824 */
            ii(0x100f_4423, 3); mov(edx, memd_a32[ss, ebp - 0x28]);     /* mov edx, [ebp-0x28] */
            ii(0x100f_4426, 3); mov(edx, memd_a32[ds, edx + 0x12]);     /* mov edx, [edx+0x12] */
            ii(0x100f_4429, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_442c, 5); calld(0x100c_f85c, -0x2_4bd5);          /* call 0x100cf85c */
            ii(0x100f_4431, 5); calld(0x100d_51e4, -0x1_f252);          /* call 0x100d51e4 */
            ii(0x100f_4436, 2); xor(ebx, ebx);                          /* xor ebx, ebx */
            ii(0x100f_4438, 2); mov(bl, al);                            /* mov bl, al */
            ii(0x100f_443a, 5); calld(0x100d_5204, -0x1_f23b);          /* call 0x100d5204 */
            ii(0x100f_443f, 2); xor(edx, edx);                          /* xor edx, edx */
            ii(0x100f_4441, 2); mov(dl, al);                            /* mov dl, al */
            ii(0x100f_4443, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_4446, 5); calld(0x100c_fa7c, -0x2_49cf);          /* call 0x100cfa7c */
            ii(0x100f_444b, 4); movsx(edx, memw_a32[ss, ebp - 0x14]);   /* movsx edx, word [ebp-0x14] */
            ii(0x100f_444f, 3); shl(edx, 0x2);                          /* shl edx, 0x2 */
            ii(0x100f_4452, 3); mov(eax, memd_a32[ss, ebp - 0x48]);     /* mov eax, [ebp-0x48] */
            ii(0x100f_4455, 6); mov(memd_a32[ds, edx + 0x101c_3853], eax); /* mov [edx+0x101c3853], eax */
            ii(0x100f_445b, 3); mov(eax, memd_a32[ss, ebp - 0x8]);      /* mov eax, [ebp-0x8] */
            ii(0x100f_445e, 5); add(eax, 0x3);                          /* add eax, 0x3 */
            ii(0x100f_4463, 3); add(memd_a32[ss, ebp - 0x18], eax);     /* add [ebp-0x18], eax */
            ii(0x100f_4466, 5); jmpd(0x100f_4330, -0x13b); goto l_0x100f_4330; /* jmp 0x100f4330 */
        l_0x100f_446b:
            ii(0x100f_446b, 3); mov(edx, memd_a32[ss, ebp - 0x24]);     /* mov edx, [ebp-0x24] */
            ii(0x100f_446e, 3); mov(eax, memd_a32[ss, ebp - 0x28]);     /* mov eax, [ebp-0x28] */
            ii(0x100f_4471, 3); mov(eax, memd_a32[ds, eax + 0x12]);     /* mov eax, [eax+0x12] */
            ii(0x100f_4474, 5); calld(Definitions.sys_display_draw_1, 0x7_302f); /* call 0x101674a8 */
            ii(0x100f_4479, 7); mov(memd_a32[ss, ebp - 0x2c], 0x1);     /* mov dword [ebp-0x2c], 0x1 */
        l_0x100f_4480:
            ii(0x100f_4480, 3); mov(eax, memd_a32[ss, ebp - 0x2c]);     /* mov eax, [ebp-0x2c] */
            ii(0x100f_4483, 2); mov(esp, ebp);                          /* mov esp, ebp */
            ii(0x100f_4485, 1); popd(ebp);                              /* pop ebp */
            ii(0x100f_4486, 1); popd(edi);                              /* pop edi */
            ii(0x100f_4487, 1); popd(esi);                              /* pop esi */
            ii(0x100f_4488, 1); popd(edx);                              /* pop edx */
            ii(0x100f_4489, 1); popd(ecx);                              /* pop ecx */
            ii(0x100f_448a, 1); popd(ebx);                              /* pop ebx */
            ii(0x100f_448b, 1); retd();                                 /* ret */
        }
    }
}
